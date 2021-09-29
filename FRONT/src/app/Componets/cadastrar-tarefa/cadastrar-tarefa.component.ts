import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Tarefa } from "src/app/Models/Tarefa";
import { TarefaService } from "src/app/Service/Tarefa.service";

@Component({
    selector: "app-cadastrar-tarefa",
    templateUrl: "./cadastrar-tarefa.component.html",
    styleUrls: ["./catarefa.component.css"],
})
export class CadastrarTarefaComponent implements OnInit {
    nome!: string;
    inicio!: number;
    descricao!: string;
    conclusao!: number;

    constructor(private service: TarefaService, private router: Router) {}

    ngOnInit(): void {}

    cadastrar(): void {
        let tarefa: Tarefa = {
            nome: this.nome,
            inicio: this.inicio,
            descricao: this.descricao,
            conclusao: this.conclusao,
        };
        this.service.create(tarefa).subscribe((tarefa) => {
            console.log(tarefa);
            this.router.navigate([""]);
        });
    }
}
