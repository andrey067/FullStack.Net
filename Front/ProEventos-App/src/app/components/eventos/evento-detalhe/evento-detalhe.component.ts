import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Evento } from 'src/app/models/evento';
import { EventoService } from '@app/services/eventoService';
import { environment } from '@environments/environment';


@Component({
  selector: 'app-evento-detalhe',
  templateUrl: './evento-detalhe.component.html',
  styleUrls: ['./evento-detalhe.component.scss']
})
export class EventoDetalheComponent implements OnInit {
  form!: FormGroup;
  eventoId?: number;
  evento = {} as Evento;
  modoEditar = false;
  loading = false;
  imagemURL = 'assets/img/upload.png';

  get lotes(): FormArray {
    return this.form.get('lotes') as FormArray;
  }

  get redesSociais(): FormArray {
    return this.form.get('redesSociais') as FormArray;
  }

  constructor(
    private fb: FormBuilder,
    private toastr: ToastrService,
    private activatedRouter: ActivatedRoute,
    private router: Router,
    private spinner: NgxSpinnerService,
    private eventoService: EventoService,
  ) {}

  public carregarEvento(): void {
    this.eventoId = Number(this.activatedRouter.snapshot.paramMap.get('id'));
    console.log(this.eventoId)

    if (this.eventoId !== null && this.eventoId !== 0) {
      this.spinner.show();

      // this.estadoSalvar = 'put';

      this.eventoService
        .getEventoById(this.eventoId)
        .subscribe(
          (evento: Evento) => {
            console.log(evento)
            this.evento = { ...evento };
            this.form.patchValue(this.evento);
            if (this.evento.imagemURL !== '') {
              this.imagemURL = environment.apiUrl+ 'resources/images/' + this.evento.imagemURL;
            }
            // this.carregarLotes();
          },
          (error: any) => {
            this.toastr.error('Erro ao tentar carregar Evento.', 'Erro!');
            console.error(error);
          }
        )
        .add(() => this.spinner.hide());
    }
  }

  ngOnInit(): void {
    this.carregarEvento();
    this.validation();
  }

  get f(): any { return this.form.controls; }

  public validation(): void {
    this.form = this.fb.group({
      id: [],
      tema: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
      local: ['', Validators.required],
      dataEvento: ['', Validators.required],
      imagemURL: [''],
      qtdPessoas: ['', [Validators.required, Validators.max(120000)]],
      telefone: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      lotes: this.fb.array([]),
      redesSociais: this.fb.array([])
    });
  }

  public resetForm(event: any): void {
    event.preventDefault();
    this.form.reset();
  }

  criaLote(lote: any): FormGroup {
    return this.fb.group({
      id: [lote.id],
      nome: [lote.nome, Validators.required],
      quantidade: [lote.quantidade, Validators.required],
      preco: [lote.preco, Validators.required],
      dataInicio: [lote.dataInicio],
      dataFim: [lote.dataFim]
    });
  }

  criaRedeSocial(redeSocial: any): FormGroup {
    return this.fb.group({
      id: [redeSocial.id],
      nome: [redeSocial.nome, Validators.required],
      url: [redeSocial.url, Validators.required]
    });
  }

  adicionarLote(): void {
    this.lotes.push(this.criaLote({ id: 0 }));
  }

  adicionarRedeSocial(): void {
    this.redesSociais.push(this.criaRedeSocial({ id: 0 }));
  }

  removerLote(id: number): void {
    this.lotes.removeAt(id);
  }

  removerRedeSocial(id: number): void {
    this.redesSociais.removeAt(id);
  }

  get bsConfig(): any {
    return {
      adaptivePosition: true,
      dateInputFormat: 'DD/MM/YYYY hh:mm a',
      containerClass: 'theme-default',
      showWeekNumbers: false,
    };
  }


}
