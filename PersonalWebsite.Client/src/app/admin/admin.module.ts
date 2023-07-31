import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutModule } from './layout/layout.module';
import { LayoutComponent } from './layout/layout.component';
import { HeaderComponent } from './layout/components/header/header.component';
import { FooterComponent } from './layout/components/footer/footer.component';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    LayoutModule
  ],
  exports:[LayoutComponent,HeaderComponent,FooterComponent]
})
export class AdminModule { }
