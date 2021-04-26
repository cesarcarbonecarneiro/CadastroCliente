import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Pessoa } from '../models/Pessoa';

@Injectable({
  providedIn: 'root'
})

export class PessoaServiceService {

  baseUrl = 'https://localhost:44379/'

  constructor(private http: HttpClient) { }

    listarPessoas(): Observable<Pessoa[]> {
      return this.http.get<Pessoa[]>(`${this.baseUrl}api/Pessoas`);
    };

    listarPessoaId(id: number): Observable<Pessoa>{
      return this.http.get<Pessoa>(`${this.baseUrl}api/Pessoas/${id}`);
    }

}
