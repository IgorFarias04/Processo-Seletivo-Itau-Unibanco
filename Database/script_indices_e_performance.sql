USE db_corretora;

CREATE INDEX idx_oper_usuario_ativo_data
ON tbl_operacoes (usuario_id, ativo_id, data_hora);


SELECT *
FROM tbl_operacoes
WHERE usuario_id = 1
  AND ativo_id = 1
  AND data_hora >= NOW() - INTERVAL 30 DAY;

/*
Justificativa do índice:

Este índice foi criado com foco em performance para a consulta que filtra operações por:
1. `usuario_id` (quem realizou a operação)
2. `ativo_id` (qual ativo foi operado)
3. `data_hora` (últimos 30 dias)

A ordenação dos campos no índice segue a seletividade:
- Primeiro `usuario_id` e `ativo_id`, pois são filtros exatos.
- Depois `data_hora`, que é um filtro de intervalo (range).

Isso permite que o MySQL utilize o índice de forma eficiente,
reduzindo tempo de resposta mesmo com grandes volumes de dados.
*/






