import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NoticiaComponent } from './noticia/noticia.component';
import { NoticiaViewComponent } from './noticia/noticia-view/noticia-view.component';
import { NoticiaCadastroComponent } from './noticia/noticia-cadastro/noticia-cadastro.component';

const routes: Routes = [
  { path: 'home/inicio', component: NoticiaComponent},
  { path: 'pesquisa/:acao', component: NoticiaComponent},
  { path: 'noticia/:id', component: NoticiaViewComponent},
  { path: 'cadastro', component: NoticiaCadastroComponent},
  { path: '**', redirectTo: 'home/inicio', pathMatch: 'full' },
  { path: '', redirectTo: 'home/inicio', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
