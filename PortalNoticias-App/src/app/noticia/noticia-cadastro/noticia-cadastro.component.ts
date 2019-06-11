import { Component, OnInit } from '@angular/core';
import { NoticiaService } from '../../_services/NoticiaService';
import { AutorService } from '../../_services/AutorService';
import { Noticia } from '../../_models/Noticia';
import { Autor } from '../../_models/Autor';
import { NgSelectConfig } from '@ng-select/ng-select';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-noticia-cadastro',
  templateUrl: './noticia-cadastro.component.html',
  styleUrls: ['./noticia-cadastro.component.css']
})
export class NoticiaCadastroComponent implements OnInit {

  titulo = 'Cadastrar Notícia';
  noticia: Noticia;
  registerForm: FormGroup;
  bodyDeletarEvento = '';
  autores: Autor[];
  autor: Autor;
  autoreSelect: any[] = [];

  constructor(private noticiaService: NoticiaService,
              private autorService: AutorService,
              private fb: FormBuilder,
              private config: NgSelectConfig,
              private toastr: ToastrService)
  {
    this.config.notFoundText = 'Custom not found';
  }

  ngOnInit() {
    this.getAutores();
    this.validation();
  }

  validation() {
    this.registerForm = this.fb.group({
      autor: ['', [Validators.required, Validators.maxLength(255)]],
      titulo: ['', [Validators.required, Validators.maxLength(255)]],
      texto: ['', Validators.required]
    });
  }

  cancelarSave(template: any) {
    this.openModal(template);
    this.bodyDeletarEvento = `Tem certeza que deseja cancelar a operação?`;
  }

  openModal(template: any) {
    template.show();
  }

  salvarAlteracao() {
    if (this.registerForm.valid) {
      this.noticia = Object.assign({}, this.registerForm.value);

      this.noticiaService.postNoticia(this.noticia).subscribe(
        (novaNoticia: Noticia) => {
          this.toastr.success('Inserido com Sucesso!');
          this.registerForm.reset();
        }, error => {
          this.toastr.error(`Erro ao Inserir: ${error}`);
        }
      );
    }
  }

  getAutores() {
    this.autorService.getAllAutor().subscribe(
      (_autores: Autor[]) => {
        this.autores = _autores;
      }, error => {
        console.log(error);
      });
  }

  addTag(name) {
    return { id: 0, nome: name };
}

}
