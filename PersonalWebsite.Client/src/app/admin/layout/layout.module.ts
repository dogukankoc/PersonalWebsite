import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutComponent } from './layout.component';

import { ComponentsModule } from './components/components.module';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { SidenavComponent } from './components/sidenav/sidenav.component';
import { DashboardComponent } from '../components/dashboard/dashboard.component';
import { DashboardModule } from '../components/dashboard/dashboard.module';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    LayoutComponent,
    
    
  ],
  imports: [
    CommonModule,
    ComponentsModule,
    RouterModule
  ],
  exports:[ComponentsModule]
})
export class LayoutModule { }
