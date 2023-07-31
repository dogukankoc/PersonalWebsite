import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BlogComponent } from './blog/blog.component';
import { ProjectComponent } from './project/project.component';
import { HeroComponent } from './hero/hero.component';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './home.component';



@NgModule({
  declarations: [
    BlogComponent,
    ProjectComponent,
    HeroComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([{path:"", component:HomeComponent}]),
  ],
  exports:[HeroComponent,BlogComponent,ProjectComponent]
})
export class HomeModule { }
