import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BlogModule } from './blog/blog.module';
import { ProjectModule } from './project/project.module';
import { UserModule } from './user/user.module';
import { DashboardModule } from './dashboard/dashboard.module';
import { BlogComponent } from './blog/blog.component';
import { ProjectComponent } from './project/project.component';
import { UserComponent } from './user/user.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { RouterModule } from '@angular/router';





@NgModule({
  declarations: [
    
  ],
  imports: [
    CommonModule,
    BlogModule,
    ProjectModule,
    UserModule,
    DashboardModule,
    RouterModule
    
  ],
  exports:[BlogComponent,ProjectComponent,UserComponent,DashboardComponent]
})
export class ComponentsModule { }
