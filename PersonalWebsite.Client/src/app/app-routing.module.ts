import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './ui/components/home/home.component';
import { ProjectComponent } from './ui/components/project/project.component';
import { BlogComponent } from './ui/components/blog/blog.component';
import { AboutmeComponent } from './ui/components/aboutme/aboutme.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'projects', component:ProjectComponent},
  {path:'blogs', component:BlogComponent},
  {path:'aboutme',component:AboutmeComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})  
export class AppRoutingModule { }
