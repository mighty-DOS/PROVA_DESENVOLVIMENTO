import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Tarefa } from "../Models/Tarefa";

@Injectable({
    providedIn: "root",
})
export class TarefaService {
    private baseURL = "https://localhost:5001/api/tarefa/list";

    constructor(private http: HttpClient) {}

    list(): Observable<Tarefa[]> {
        return this.http.get<Tarefa[]>(`${this.baseURL}/list`);
    }

    create(tarefa: Tarefa): Observable<Tarefa> {
        return this.http.post<Tarefa>(`${this.baseURL}/create`, tarefa);
    }
}