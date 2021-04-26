import { Endereco } from "./Endereco";

export class Pessoa {
    [x: string]: any;
    id!: number;
    nome!: string;
    cpf!: string;
    email!: string;
    dataNascimento!: Date;
    enderecos!: Endereco[];
}
