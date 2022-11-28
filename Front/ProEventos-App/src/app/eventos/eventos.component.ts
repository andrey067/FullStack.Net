import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Evento } from '../models/evento.model';
import { Responses } from '../models/response.model';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  eventos: Evento[] = [];
  eventosFiltrados: Evento[] = [];
  mostrarImagem = true;
  private _filtroLista: string = '';

  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.buscarEventos();
  }

  alterarStatusImagem(): void {
    this.mostrarImagem = !this.mostrarImagem;
  }

  public buscarEventos() {
    this.http.get<Responses<Evento[]>>("https://localhost:5001/eventos").subscribe(result => {
      this.eventos = result.Data;
      this.eventosFiltrados = result.Data;
    },
      error => console.log(error));
  }

  filtrarEventos(filtrarPor: string): Evento[] {
    filtrarPor = filtrarPor.toLowerCase();
    return this.eventos.filter((evento: Evento) => evento.Tema.toLowerCase().indexOf(filtrarPor) !== -1 || evento.Local.toLowerCase().indexOf(filtrarPor) !== -1)
  }
}
