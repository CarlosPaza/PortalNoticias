import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
import { ModalModule } from 'ngx-bootstrap';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { FooterComponent } from './footer/footer.component';
import { NoticiaComponent } from './noticia/noticia.component';
import { TituloComponent } from './_shared/titulo/titulo.component';
import { NoticiaViewComponent } from './noticia/noticia-view/noticia-view.component';
import { NoticiaCadastroComponent } from './noticia/noticia-cadastro/noticia-cadastro.component';

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      FooterComponent,
      NoticiaComponent,
      TituloComponent,
      NoticiaViewComponent,
      NoticiaCadastroComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
      FormsModule,
      BrowserAnimationsModule,
      NgSelectModule,
      ModalModule.forRoot(),
      ToastrModule.forRoot({
         timeOut: 3000,
         preventDuplicates: true,
         progressBar: true
      }),
      ReactiveFormsModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
