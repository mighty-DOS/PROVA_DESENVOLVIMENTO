import { Tarefa } from './../../Models/Tarefa';
import { Component, OnInit } from "@angular/core";
import { TarefaService } from "src/app/Service/Tarefa.service";

@Component({
    selector: "app-listar-tarefa",
    templateUrl: "./listar-tarefa.component.html",
    styleUrls: ["./listar-tarefa.component.css"],
})
export class ListarTarefaComponent implements OnInit {
    tarefas: Tarefa[] = [];

    constructor(private service: TarefaService) {}

    ngOnInit(): void {
        this.service.list().subscribe((tarefas) => {
            this.tarefas = tarefas;
            for (let tarefa of tarefas) {
                console.log(tarefas);
            }
        });
    }
}