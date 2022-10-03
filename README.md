# AGENDAMENTO DE TAREFAS

## Projeto  criado  com  c# e entity fremework Core.

### Modelo da tarefa 
![image](https://user-images.githubusercontent.com/88563085/193653551-afb5921a-6fa1-414d-90ec-3811455869ad.png)

# Endpoints 

<table>
<thead>
<tr>
<th>Verbo</th>
<th><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ponto final</font></font></th>
<th>Parâmetro</th>
<th><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Corpo</font></font></th>
</tr>
</thead>
<tbody>
<tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">PEGUE</font></font></td>
<td>/Tarefa/{id}</td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Eu iria</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">N / D</font></font></td>
</tr>
<tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">COLOCAR</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">/Tarefa/{id}</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Eu iria</font></font></td>
<td>Schema Tarefa</td>
</tr>
<tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">EXCLUIR</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">/Tarefa/{id}</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Eu iria</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">N / D</font></font></td>
</tr>
<tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">PEGUE</font></font></td>
<td>/Tarefa/ObterTodos</td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">N / D</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">N / D</font></font></td>
</tr>
<tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">PEGUE</font></font></td>
<td>/Tarefa/ObterPorTitulo</td>
<td>titulo</td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">N / D</font></font></td>
</tr>
<tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">PEGUE</font></font></td>
<td>/Tarefa/ObterPorData</td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">dados</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">N / D</font></font></td>
</tr>
<tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">PEGUE</font></font></td>
<td>/Tarefa/ObterPorStatus</td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">status</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">N / D</font></font></td>
</tr>
<tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">PUBLICAR</font></font></td>
<td>/Tarefa</td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">N / D</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Schema Tarefa</font></font></td>
</tr>
</tbody>
</table>

# schema(model) de uma tarefa. 

<pre>{
  <span class="pl-ent">"id"</span>: <span class="pl-c1">0</span>,
  <span class="pl-ent">"titulo"</span>: <span class="pl-s"><span class="pl-pds">"</span>string<span class="pl-pds">"</span></span>,
  <span class="pl-ent">"descricao"</span>: <span class="pl-s"><span class="pl-pds">"</span>string<span class="pl-pds">"</span></span>,
  <span class="pl-ent">"data"</span>: <span class="pl-s"><span class="pl-pds">"</span>2022-06-08T01:31:07.056Z<span class="pl-pds">"</span></span>,
  <span class="pl-ent">"status"</span>: <span class="pl-s"><span class="pl-pds">"</span>Pendente<span class="pl-pds">"</span></span>
}</pre>
