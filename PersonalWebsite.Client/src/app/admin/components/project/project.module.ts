import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProjectComponent } from './project.component';
import { RouterModule } from '@angular/router';
import { CreateprojectComponent } from './components/createproject/createproject.component';
import { UpdateprojectComponent } from './components/updateproject/updateproject.component';
import { CreateprojectModule } from './components/createproject/createProject.module';
import { UpdateprojectModule } from './components/updateproject/updateproject.module';



@NgModule({
  declarations: [
    ProjectComponent,
    
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([{path:'', component:ProjectComponent}]),
    CreateprojectModule,
    UpdateprojectModule
  ],
  exports:[ProjectComponent]
})
export class ProjectModule { }
