import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './ui/components/home/home.component';
import { ProjectComponent } from './ui/components/project/project.component';
import { BlogComponent } from './ui/components/blog/blog.component';
import { AboutmeComponent } from './ui/components/aboutme/aboutme.component';
import { LayoutComponent } from './admin/layout/layout.component';
import { DashboardComponent } from './admin/components/dashboard/dashboard.component';

const routes: Routes = [
{path:'admin', component:LayoutComponent,children:[
  {path:'', component:DashboardComponent},
  {path:'blogs', loadChildren: () => import('./admin/components/blog/blog.module').then(module => module.BlogModule)},
  {path:'projects', loadChildren:() => import('./admin/components/project/project.module').then(module => module.ProjectModule)},
  {path:'users', loadChildren:() => import('./admin/components/user/user.module').then(module => module.UserModule)}
  ]
},

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
