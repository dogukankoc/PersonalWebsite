import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AdminModule } from './admin/admin.module';
import { UiModule } from './ui/ui.module';
import { ProjectService } from './core/services/project.service';
import { BlogService } from './core/services/blog.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AdminModule,
    UiModule,
    HttpClientModule
  ],
  providers: [{provide:'url', useValue:"https://localhost:7198/"},BlogService,ProjectService],
  bootstrap: [AppComponent]
})
export class AppModule { }
