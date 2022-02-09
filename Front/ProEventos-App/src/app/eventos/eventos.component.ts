import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public evento: any;
  public eventosfiltrados: any = [];
  mostrarImagem: boolean = true;
  private _filtroLista: string = '';

  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.evento = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.evento;
  }

  public filtrarEventos(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.evento.filter(
      (ev: { tema: string; local: string; }) => ev.tema.toLocaleLowerCase().indexOf(filtrarPor) ||
        ev.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1);
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  mostrar_esconder_Imagem() {
    this.mostrarImagem = !this.mostrarImagem;
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/evento').subscribe(
      reponse => {
        this.evento = reponse,
          this.eventosfiltrados = this.evento
      },
      error => console.log(error)
    )
  }
}
