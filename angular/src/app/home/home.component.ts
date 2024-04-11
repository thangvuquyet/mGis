import { Component, Injector, ChangeDetectionStrategy } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { Chart } from 'chart.js/auto';
@Component({
  templateUrl: './home.component.html',
  animations: [appModuleAnimation()],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class HomeComponent extends AppComponentBase {
  LineChart =[];
  constructor(injector: Injector) {
    super(injector);
  }
  ngOnInit(): void {
    var LineChart1 = new Chart('linechart', {
      type: 'line',
      data: {
        labels: ["Sep", "Oct", "Nov", "Dec","Jan"],
        datasets: [{
          label: 'pH',
          data: [6.5  , 6.5 , 6.5 , 6.5 , 6.5 , 6.5 ],
          fill: false,
          borderWidth: 2.5,
          borderColor: 'rgb(75, 192, 192)',
          pointStyle: 'star',
          pointBorderWidth: 2,
        }]
      },
      options: {
        responsive: true,
        plugins: {
          legend: {
            position: 'bottom',
          },
        }
      },
    });

    var LineChart2 = new Chart('linechart2', {
      type: 'line',
      data: {
        labels: ["Sep", "Oct", "Nov", "Dec","Jan"],
        datasets: [{
          label: 'TDS',
          data: [1594, 1795, 1805, 1811, 1800, 1757],
          fill: false,
          borderWidth: 2.5,
          borderColor: 'red',
          pointStyle: 'star',
          pointBorderWidth: 2,
        }]
      },
      options: {
        responsive: true,
        plugins: {
          legend: {
            position: 'bottom',
          },
        }
      },
    });
  
  }
}
