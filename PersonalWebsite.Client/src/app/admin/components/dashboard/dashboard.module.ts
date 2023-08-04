import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './dashboard.component';
import { RouterModule } from '@angular/router';
import { SidenavComponent } from '../../layout/components/sidenav/sidenav.component';
;



@NgModule({
  declarations: [
    DashboardComponent,
    
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([{path:'', component:DashboardComponent}]),
    
  ],
  exports:[DashboardComponent]
})
export class DashboardModule { }
