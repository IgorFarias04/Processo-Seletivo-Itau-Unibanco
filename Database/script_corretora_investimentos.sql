CREATE DATABASE db_corretora;

USE db_corretora;

-- Tabela de usuários
CREATE TABLE tbl_usuarios (
    usuario_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(320) NOT NULL UNIQUE,
    corretagem_percentual DECIMAL(5,2) NOT NULL DEFAULT 0.00
);

-- Tabela de ativos
CREATE TABLE tbl_ativos (
    ativo_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    codigo VARCHAR(12) NOT NULL UNIQUE,
    nome VARCHAR(100) NOT NULL
);

-- Tabela de operações
CREATE TABLE tbl_operacoes (
    operacao_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT NOT NULL,
    ativo_id INT NOT NULL,
    qtd INT NOT NULL,
    preco_unit DECIMAL(15,4) NOT NULL,
    tipo_op ENUM('COMPRA', 'VENDA') NOT NULL,
    corretagem_valor DECIMAL(10,2) NOT NULL,
    data_hora DATETIME NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES tbl_usuarios(usuario_id),
    FOREIGN KEY (ativo_id) REFERENCES tbl_ativos(ativo_id)
);

-- Tabela de cotações
CREATE TABLE tbl_cotacoes (
    cotacao_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    ativo_id INT NOT NULL,
    preco_unit DECIMAL(15,4) NOT NULL,
    data_hora DATETIME NOT NULL,
    FOREIGN KEY (ativo_id) REFERENCES tbl_ativos(ativo_id)
);

-- Tabela de posições
CREATE TABLE tbl_posicoes (
    posicao_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT NOT NULL,
    ativo_id INT NOT NULL,
    qtd INT NOT NULL,
    preco_medio DECIMAL(15,4) NOT NULL,
    pl DECIMAL(15,4) NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES tbl_usuarios(usuario_id),
    FOREIGN KEY (ativo_id) REFERENCES tbl_ativos(ativo_id)
);    

/*
====================================================
 Justificativas para escolha dos tipos de dados:
====================================================

1. INT:
   - Usado para IDs, quantidades e chaves estrangeiras.
   - Suporta valores inteiros suficientes para milhões de registros.
   - Compatível com AUTO_INCREMENT para geração automática de IDs.

2. VARCHAR:
   - `nome`: até 100 caracteres, suficiente para nomes de pessoas e ativos.
   - `email`: até 320 caracteres, conforme a RFC 5321 (64 + @ + 255).
   - `codigo`: até 12 caracteres para códigos de ativos (ex: PETR4, AAPL34F).

3. DECIMAL:
   - Usado para valores financeiros com precisão exata (evita arredondamentos).
   - `DECIMAL(15,4)`: para preços e P&L (até trilhões com 4 casas decimais).
   - `DECIMAL(10,2)`: para corretagens (valores em R$ com 2 casas decimais).
   - `DECIMAL(5,2)`: para porcentagem de corretagem (até 99.99%).

4. ENUM:
   - Usado no campo `tipo_op` para limitar operações a apenas 'COMPRA' ou 'VENDA'.
   - Garante integridade sem necessidade de tabela auxiliar.

5. DATETIME:
   - Usado para armazenar data e hora de operações e cotações com precisão total.

====================================================
*/