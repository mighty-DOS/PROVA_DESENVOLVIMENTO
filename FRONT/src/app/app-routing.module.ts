import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CadastrarTarefaComponent } from "./Componets/cadastrar-tarefa/cadastrar-tarefa.component";
import { ListarTarefaComponent } from "./Componets/listar-tarefa/listar-tarefa.component";

const routes: Routes = [
    {
        path: "",
        component: ListarTarefaComponent,
    },
    {
        path: "produto/listar",
        component: ListarTarefaComponent,
    },
    {
        path: "produto/cadastrar",
        component: CadastrarTarefaComponent,
    },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}
