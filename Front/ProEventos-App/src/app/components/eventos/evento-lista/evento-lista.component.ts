import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { Evento } from 'src/app/models/evento';
import { EventoService } from 'src/app/services/eventoService';
import { BsDropdownConfig } from 'ngx-bootstrap/dropdown';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from 'ngx-spinner';


@Component({
  selector: 'app-evento-lista',
  templateUrl: '../evento-lista/evento-lista.component.html',
  styleUrls: ['./evento-lista.component.scss'],
  providers: [{ provide: BsDropdownConfig, useValue: { isAnimated: true, autoClose: true } }]
})
export class EventoListaComponent implements OnInit {
  modalRef!: BsModalRef;
  public eventos: Evento[] = [];
  public eventosFiltrados: Evento[] = [];
  public larguraImagem = 100;
  public margemImagem = 2;
  public exibirImagem = true;
  private filtroListado = '';
  public eventoId = 0;

  public get filtroLista(): string {
    return this.filtroListado;
  }

  public set filtroLista(value: string) {
    this.filtroListado = value;
    this.eventosFiltrados = this.filtroLista
      ? this.filtrarEventos(this.filtroLista)
      : this.eventos;
  }

  public filtrarEventos(filtrarPor: string): Evento[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento) =>
        evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
        evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }
  constructor(
    private eventoService: EventoService,
    private router: Router,
    private modalService: BsModalService,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService
  ) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public alterarImagem(): void {
    this.exibirImagem = !this.exibirImagem;
  }

  public getEventos(): void {
    this.spinner.show();
    this.eventoService.getEventos().subscribe({
      next: (eventos: Evento[]) => {
        this.eventos = eventos;
        this.eventosFiltrados = this.eventos;
      },
      error: (error: any) => {
        this.spinner.hide();
        this.toastr.error('Erro ao Carregar os Eventos', 'Erro!');
      },
      complete: () => this.spinner.hide(),
    });
  }

  detalhesEvento(id: Number): void {
    this.router.navigate([`eventos/detalhe/${id}`]);
  }

  openModal(event: any, template: TemplateRef<any>, eventoId: number): void {
    event.stopPropagation();
    this.eventoId = eventoId;
    this.modalRef = this.modalService.show(template, { class: 'modal-sm modal-dialog-centered' });
  }


  confirm(): void {
    this.spinner.show();
    this.modalRef.hide();
    this.eventoService.deleteEvento(this.eventoId)
      .subscribe(
        (result: any) => {
          console.log(result);
          if (result.mensagem === 'Deletado') {
            this.toastr.success("Evento deletado com sucesso")
            this.spinner.hide();
            this.getEventos();
          }
        },
        (error: any) => {
          console.error(error);
          this.toastr.error(
            `Erro ao tentar deletar o evento ${this.eventoId}`,
            'Erro'
          );
        }
      )
      .add(() => this.spinner.hide());
  }

  decline(): void {
    this.modalRef.hide();
  }
}
