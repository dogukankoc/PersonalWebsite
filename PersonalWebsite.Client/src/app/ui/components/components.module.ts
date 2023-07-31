import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { HomeModule } from './home/home.module';
import { RouterModule } from '@angular/router';
import { ProjectModule } from './project/project.module';
import { AboutmeModule } from './aboutme/aboutme.module';
import { BlogModule } from './blog/blog.module';



@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    CommonModule,HomeModule,RouterModule,ProjectModule,AboutmeModule,BlogModule
  ],
  exports:[HomeComponent]
})
export class ComponentsModule { }
