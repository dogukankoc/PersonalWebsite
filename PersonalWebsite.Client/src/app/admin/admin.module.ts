import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutModule } from './layout/layout.module';
import { LayoutComponent } from './layout/layout.component';
import { HeaderComponent } from './layout/components/header/header.component';
import { FooterComponent } from './layout/components/footer/footer.component';
import { SidenavComponent } from './layout/components/sidenav/sidenav.component';
import { ComponentsModule } from './components/components.module';
import { BlogComponent } from './components/blog/blog.component';
import { ProjectComponent } from './components/project/project.component';
import { UserComponent } from './components/user/user.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    LayoutModule,
    ComponentsModule,
    RouterModule

  ],
  exports:[LayoutModule,ComponentsModule]
})
export class AdminModule { }
