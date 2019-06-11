import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Noticia } from '../_models/Noticia';

@Injectable({
  providedIn: 'root'
})
export class NoticiaService {
  baseURL = 'http://localhost:5000/api/noticia';

  constructor(private http: HttpClient) { }

  getAllNoticia(): Observable<Noticia[]> {
    return this.http.get<Noticia[]>(this.baseURL);
  }

  getNoticiaByTexto(texto: string): Observable<Noticia[]> {
    return this.http.get<Noticia[]>(`${this.baseURL}/busca/${texto}`);
  }

  getNoticiaById(id: number): Observable<Noticia> {
    return this.http.get<Noticia>(`${this.baseURL}/${id}`);
  }

  postNoticia(noticia: Noticia) {
    return this.http.post(this.baseURL, noticia);
  }

}