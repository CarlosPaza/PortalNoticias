import { Component, OnInit } from '@angular/core';
import { NoticiaService } from '../../_services/NoticiaService';
import { Noticia } from '../../_models/Noticia';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-noticia-view',
  templateUrl: './noticia-view.component.html',
  styleUrls: ['./noticia-view.component.css']
})
export class NoticiaViewComponent implements OnInit {

  id = +this.router.snapshot.paramMap.get('id');
  noticia: Noticia;

  constructor(private eventoService: NoticiaService, private router: ActivatedRoute) { }

  ngOnInit() {
    this.getNoticia(this.id);
  }

  getNoticia(id: number) {
    this.eventoService.getNoticiaById(id).subscribe(
      (_noticias: Noticia) => {
        this.noticia = _noticias;
      }, error => {
        console.log(error);
      });
  }

}
