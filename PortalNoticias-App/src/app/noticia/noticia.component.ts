import { Component, OnInit } from '@angular/core';
import { NoticiaService } from '../_services/NoticiaService';
import { Noticia } from '../_models/Noticia';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-noticia',
  templateUrl: './noticia.component.html',
  styleUrls: ['./noticia.component.css']
})
export class NoticiaComponent implements OnInit {

  acao = +this.router.snapshot.paramMap.get('acao');
  titulo: string;
  noticiasFiltradas: Noticia[];
  noticias: Noticia[];
  noticia: Noticia;
  filtrolista = '';

  get filtroLista(): string {
    return this.filtrolista;
  }
  set filtroLista(value: string) {
    this.filtrolista = value;
  }

  constructor(private noticiaService: NoticiaService, private router: ActivatedRoute) { }

  ngOnInit() {
    this.getAcao();
    this.getNoticias(this.acao);
  }

  getNoticias(acao) {
    if (acao != 1) {
      this.noticiaService.getAllNoticia().subscribe(
        (_noticias: Noticia[]) => {
          this.noticias = _noticias;
          this.noticiasFiltradas = this.noticias;
        }, error => {
          console.log(error);
        });
    }
  }

  getAcao() {
    if (this.acao === 1) {
      this.titulo = 'Pesquisar Notícia';
    } else {
      this.titulo = 'Últimas Notícias';
    }
  }

  filtrarNoticias(filtrarPor: string): any {
    if (filtrarPor != '') {
      this.noticiaService.getNoticiaByTexto(filtrarPor).subscribe(
        (_noticias: Noticia[]) => {
          this.noticias = _noticias;
          this.noticiasFiltradas = this.noticias;
        }, error => {
          console.log(error);
        });
    } else {
      this.getNoticias(2);
    }
  }

  onKeydown(event) {
    if (event.key === 'Enter') {
      this.filtrarNoticias(this.filtroLista);
    }
  }

}
