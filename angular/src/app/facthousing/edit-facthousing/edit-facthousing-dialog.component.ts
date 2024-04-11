import {
  Component,
  Injector,
  OnInit,
  EventEmitter,
  Output
} from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { forEach as _forEach, includes as _includes, map as _map } from 'lodash-es';
import { AppComponentBase } from '@shared/app-component-base';
import {
  // UserServiceProxy,
  // UserDto,
  // RoleDto,
  FactHousingList,
  FactHousingServiceServiceProxy
} from '@shared/service-proxies/service-proxies';

@Component({
  templateUrl: './edit-facthousing-dialog.component.html'
})
export class EditFacthousingDialogComponent extends AppComponentBase
  implements OnInit {
  saving = false;
  facthousing = new FactHousingList();
  // roles: RoleDto[] = [];
  // checkedRolesMap: { [key: string]: boolean } = {};
  id: string;

  @Output() onSave = new EventEmitter<any>();

  constructor(
    injector: Injector,
    public _facthousingService: FactHousingServiceServiceProxy,
    public bsModalRef: BsModalRef
  ) {
    super(injector);  
  }

  ngOnInit(): void {
    this._facthousingService.get(this.id).subscribe((result) => {
      this.facthousing = result;

      // this._userService.getRoles().subscribe((result2) => {
      //   this.roles = result2.items;
      //   this.setInitialRolesStatus();
      // });
    });
  }

  // setInitialRolesStatus(): void {
  //   _map(this.roles, (item) => {
  //     this.checkedRolesMap[item.normalizedName] = this.isRoleChecked(
  //       item.normalizedName
  //     );
  //   });
  // }

  // isRoleChecked(normalizedName: string): boolean {
  //   return _includes(this.user.roleNames, normalizedName);
  // }

  // onRoleChange(role: RoleDto, $event) {
  //   this.checkedRolesMap[role.normalizedName] = $event.target.checked;
  // }

  // getCheckedRoles(): string[] {
  //   const roles: string[] = [];
  //   _forEach(this.checkedRolesMap, function (value, key) {
  //     if (value) {
  //       roles.push(key);
  //     }
  //   });
  //   return roles;
  // }

  save(): void {
    this.saving = true;

    // this.user.roleNames = this.getCheckedRoles();

    this._facthousingService.update(this.facthousing).subscribe(
      () => {
        this.notify.info(this.l('SavedSuccessfully'));
        this.bsModalRef.hide();
        this.onSave.emit();
      },
      () => {
        this.saving = false;
      }
    );
  }
}
