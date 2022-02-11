import { Component, OnInit } from '@angular/core';
import { Evento } from '../models/Evento';
import { EventoService } from '../services/evento.service';


@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
})

export class EventosComponent implements OnInit {

  public eventos: Evento[] = [];
  public eventosfiltrados: Evento[] = [];
  mostrarImagem: boolean = true;
  private _filtroLista: string = '';

  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.eventos = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
  }

  public filtrarEventos(filtrarPor: string): Evento[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (ev: { tema: string; local: string; }) => ev.tema.toLocaleLowerCase().indexOf(filtrarPor) ||
        ev.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1);
  }

  constructor(private eventoService: EventoService) { }
  public ngOnInit(): void {
    this.getEventos();
  }

  public mostrar_esconder_Imagem() {
    this.mostrarImagem = !this.mostrarImagem;
  }

  public getEventos(): void {
    this.eventoService.getEventos().subscribe(
      (eventos: Evento[]) => {
        this.eventos = eventos,
          this.eventosfiltrados = this.eventos
      },
      error => console.log(error)
    )
  }
}
