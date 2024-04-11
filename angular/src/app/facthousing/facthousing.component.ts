import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  PagedListingComponentBase,
  PagedRequestDto
} from 'shared/paged-listing-component-base';
import {
  // UserServiceProxy,
  // UserDto,
  // UserDtoPagedResultDto,
  FactHousingList,
  FactHousingServiceServiceProxy,
  FactHousingListPagedResultDto
} from '@shared/service-proxies/service-proxies';
import { CreateFacthousingDialogComponent } from './create-facthousing/create-facthousing-dialog.component';
import { EditFacthousingDialogComponent } from './edit-facthousing/edit-facthousing-dialog.component';
// import { CreateUserDialogComponent } from './create-user/create-user-dialog.component';
// import { EditUserDialogComponent } from './edit-user/edit-user-dialog.component';
// import { ResetPasswordDialogComponent } from './reset-password/reset-password.component';

class PagedFactHousingRequestDto extends PagedRequestDto {
  keyword: string
}

@Component({

  templateUrl: './facthousing.component.html',
  animations: [appModuleAnimation()]
})
export class FactHousingComponent extends PagedListingComponentBase<FactHousingList> {
  facthousings: FactHousingList[] = [];
  keyword = '';
  advancedFiltersVisible = false;

  constructor(
    injector: Injector,
    private _facthousingService: FactHousingServiceServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  createFactHousing(): void {
    this.showCreateOrEditFactHousingDialog();
  }

  editFactHousing(facthousing: FactHousingList): void {
    this.showCreateOrEditFactHousingDialog(facthousing.id);
  }

  clearFilters(): void {
    this.keyword = '';
    this.getDataPage(1);
  }

  protected list(
    request: PagedFactHousingRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;
    this._facthousingService
      .getAll(  
        request.keyword,
        request.skipCount,
        request.maxResultCount
      )
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: FactHousingListPagedResultDto) => {
        this.facthousings = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  protected delete(facthousing: FactHousingList): void {
    abp.message.confirm(
      this.l('FactHousingDeleteWarningMessage', facthousing.houseID),
      undefined,
      (result: boolean) => {
        if (result) {
          this._facthousingService.delete(facthousing.id).subscribe(() => {
            abp.notify.success(this.l('SuccessfullyDeleted'));
            this.refresh();
          });
        }
      }
    );
  }

  private showCreateOrEditFactHousingDialog(id?: string): void {
    let createOrEditUserDialog: BsModalRef;
    if (!id) {
      createOrEditUserDialog = this._modalService.show(
        CreateFacthousingDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditUserDialog = this._modalService.show(
        EditFacthousingDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditUserDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }
}
