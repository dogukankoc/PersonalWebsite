import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutComponent } from './layout.component';

import { ComponentsModule } from './components/components.module';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';



@NgModule({
  declarations: [
    LayoutComponent,
    
    
  ],
  imports: [
    CommonModule,
    ComponentsModule
  ],
  exports:[LayoutComponent,HeaderComponent,FooterComponent]
})
export class LayoutModule { }
