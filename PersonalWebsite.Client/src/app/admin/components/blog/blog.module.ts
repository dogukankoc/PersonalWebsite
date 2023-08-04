import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BlogComponent } from './blog.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    BlogComponent,
    
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([{path:'', component:BlogComponent}]) 
  ],
  exports:[BlogComponent]

})
export class BlogModule { }
