import { BaseEntity } from "./BaseEntity";

export interface RedeSocial extends BaseEntity {
  nome: string;
  URL: string;
  eventoId: number;
  palestranteId: number;
}
