import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Endereco } from '../models/Endereco';
import { Pessoa } from '../models/Pessoa';
import { PessoaServiceService } from '../services/PessoaService';

@Component({
  selector: 'app-pessoas',
  templateUrl: './pessoas.component.html',
  styleUrls: ['./pessoas.component.css']
})
export class PessoasComponent implements OnInit {

  public endereco!: Endereco;
  public enderecosGrid!: Endereco[];
  public editarPessoa = false;
  public inserirPessoa = false;
  public pessoaSelecionada!: Pessoa;
  public pessoas!: Pessoa[];
  public pessoaForm!: FormGroup;

  adicionarEnderecoGrid (endereco: Endereco){
    this.enderecosGrid = this.enderecosGrid.concat(endereco);
  }

  editar(pessoa: Pessoa) {  
    this.pessoaService.listarPessoaId(pessoa.id).subscribe(
      (pessoas: Pessoa) => {
        this.pessoaSelecionada = pessoas;
      },
      (erro: any) => {
        console.error(erro);
      });
      this.editarPessoa = true;  
  }

  cadastrarPessoa(){
    this.inserirPessoa = true;
  }
  voltar(){
    this.editarPessoa = false;
    this.inserirPessoa = false;
  }

  carregarPessoas(){
    this.pessoaService.listarPessoas().subscribe(
      (pessoas: Pessoa[]) => {
          this.pessoas = pessoas;
      },
      (erro: any) => {
        console.error(erro);
      }
    );
  }

  criarForm(){
    this.pessoaForm = this.fb.group({
      nome: ['',Validators.required],
      cpf: ['',Validators.required,Validators.maxLength(11),Validators.minLength(11)],
      email: ['',Validators.required,Validators.email],
      dataNascimento: ['',Validators.required]
    })
  }

  constructor(private fb: FormBuilder,
              private pessoaService: PessoaServiceService) {
    this.criarForm();
  }

  ngOnInit(): void {
    this.carregarPessoas();
  }

}
