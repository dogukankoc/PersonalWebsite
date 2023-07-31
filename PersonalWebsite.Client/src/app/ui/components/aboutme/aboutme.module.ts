import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AboutmeComponent } from './aboutme.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    AboutmeComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {path:'', component:AboutmeComponent}
    ])
  ]
})
export class AboutmeModule { }
