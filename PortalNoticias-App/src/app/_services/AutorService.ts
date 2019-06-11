import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Autor } from '../_models/Autor';

@Injectable({
  providedIn: 'root'
})
export class AutorService {
  baseURL = 'http://localhost:5000/api/autor';

  constructor(private http: HttpClient) { }

  getAllAutor(): Observable<Autor[]> {
    return this.http.get<Autor[]>(this.baseURL);
  }

  getAutorByTexto(texto: string): Observable<Autor[]> {
    return this.http.get<Autor[]>(`${this.baseURL}/busca/${texto}`);
  }

  getAutorById(id: number): Observable<Autor> {
    return this.http.get<Autor>(`${this.baseURL}/${id}`);
  }

  postAutor(autor: Autor) {
    return this.http.post(this.baseURL, autor);
  }

}