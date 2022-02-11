import { BaseEntity } from "./BaseEntity";
import { Evento } from "./Evento";
import { RedeSocial } from "./RedeSocial";

export interface Palestrante extends BaseEntity {
  nome: string;
  miniCurriculo: string;
  imagemURL: string;
  telefone: string;
  email: string;
  redeSociais: RedeSocial[];
  palestrantesEventos: Evento[];
}
