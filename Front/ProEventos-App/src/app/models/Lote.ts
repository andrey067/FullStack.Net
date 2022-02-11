import { BaseEntity } from "./BaseEntity";
import { Evento } from "./Evento";

export interface Lote extends BaseEntity{
  nome: string;
  preco: number;
  dataIncio: Date;
  dataFim: Date;
  quantidade: number;
  eventoId: number;
  evento: Evento[];
}
