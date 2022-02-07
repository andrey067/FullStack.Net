import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public evento: any;
  mostrarImagem: boolean = true;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  mostrar_esconder_Imagem() {
    this.mostrarImagem = !this.mostrarImagem;
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/evento').subscribe(
      reponse => this.evento = reponse,
      error => console.log(error)
    )
  }
}
