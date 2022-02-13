import { RedeSocial } from './RedeSocial';
import { Lote } from "./Lote";
import { Palestrante } from './Palestrante';
import { BaseEntity } from './BaseEntity';

export interface Evento extends BaseEntity {
  local: string;
  dataEvento?: Date;
  tema: string;
  qtdPessoas: number;
  imagemURL: string;
  telefone: string;
  email: string;
  lotes: Lote[];
  redesSociais: RedeSocial[];
  palestrantesEventos: Palestrante[];
}
