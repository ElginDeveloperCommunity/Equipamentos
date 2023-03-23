# Etiquetas Eletrônicas

### Descrição dos Abreviações
| Abreviação | Nome | Descrição | 
| :--- | :--- | :--- |
| AP | Wireless Access Point | Antena / Roteador que controla as etiquetas eletrônicas | 
| API | Application Programming Interface | Um conjunto de funções predefinidas para aplicações e desenvolvedores acessarem uma rotina baseada em um software, sem ter acesso ao código fonte ou necessário entendimento do processo |
| ESL | Eletronic Shelf Label | Etiqueta Eletrônica |
| PriSmart | PriSmart Smart Retail System | Plataforma que gerencia etiquetas e produtos das lojas |

# Biblioteca

### Retornos

| Código | Descrição |
| :----: | :-------- |
| -9 | Erro ao obter dados de homologação |
| -8 | Erro ao abrir arquivo |
| -7 | Erro ao ler arquivo |
| -6 | Erro nos parametros da função |
| -5 | Erro no arquivo JSON |
| -4 | Token Elgin inválido |
| -3 | Erro no arquivo de Configuração |
| -2 | Erro no arquivo de Setup |
| -1 | Erro no processo de Login |
|  0 | Erro na execução local da função |
|  1 | Função ou processo executado com sucesso |
|  n | String contendo o retorno do comando solicitado |

### Arquivos necessários

* configParametros.json
* lib_esl.dll

## Funções

### SetupConfigLogin 

`int SetupConfigLogin(username *char, password *char, clientID *char, clientSecret *char)`
* Configurar os parametros de Login. 
   Uma vez efetuado o cadastro, as informações são armazenadas em arquivo criptografado (configSetup.bin). 
   Não sendo necessário efetuar a config novamente.
   
* Modo dev
	SetupConfigLogi("dev", "dev", "dev", "dev")
	Pegar o token na plataforma da Elgin e atualizar o mesmo no arquivo "configParametros.json" na chave "Token"
	
* Modo Prod
	Inserir os parametros obtidos pela Elgin para acesso direto a plataforma das ESL.
   
### Blink

`*char Blink(eslId *char, goodsId *char, led_color *char, led_count int, led_on_time int, led_off_time int, int, int, int)`
* Setup das informações de blink do LED
* Parametros conforme doc da API

### BlinkArq

`*char BlinkArq(path *char)`
* Setup das informações de blink do LED
* Se "path" conter a informação "Path=" indicará que as informações deverão ser carregadas de um determinado arquivo. Ex: `"Path=C:\\TESTE\\teste.txt"`
* Caso contrário, a função entenderá que o próprio texto passado (formato JSON), como informação, deverá ser utilizado. Ex: `"[{\"texto\":\"texto\"}]"`
* Parametros conforme doc da API

### Bind

`*char Bind(eslId *char, goodsId *char, goodsSku *char, position int, extra *char)`
* Associar ESL
* Parametros conforme doc da API

### BindArq

`*char BindArq(path *char)`
* Associar ESL(s)
* Se "path" conter a informação "Path=" indicará que as informações deverão ser carregadas de um determinado arquivo. Ex: `"Path=C:\\TESTE\\teste.txt"`
* Caso contrário, a função entenderá que o próprio texto passado (formato JSON), como informação, deverá ser utilizado. Ex: `"[{\"texto\":\"texto\"}]"`
* Parametros conforme doc da API

### Unbind 

`*char Unbind(eslId *char, goodsId *char)`
* Desassociar ESL
* Parametros conforme doc da API

### UnbindArq

`*char UnbindArq(path *char)`
* Desassociar ESL(s)
* Se "path" conter a informação "Path=" indicará que as informações deverão ser carregadas de um determinado arquivo. Ex: `"Path=C:\\TESTE\\teste.txt"`
* Caso contrário, a função entenderá que o próprio texto passado (formato JSON), como informação, deverá ser utilizado. Ex: `"[{\"texto\":\"texto\"}]"`
* Parametros conforme doc da API

### AtualizarESL

`*char AtualizarESL(path *char, store *char)`
* Atualizar/Modificar status das ESL(s)
* store: parametro associado a loja
* Parametros conforme doc da API
* Se "path" conter a informação "Path=" indicará que as informações deverão ser carregadas de um determinado arquivo. Ex: `"Path=C:\\TESTE\\teste.txt"`
* Caso contrário, a função entenderá que o próprio texto passado (formato JSON), como informação, deverá ser utilizado. Ex: `"[{\"texto\":\"texto\"}]"`

### GetAllStatus

`int GetAllStatus(path *char, store *char)`
* Get status de todas as ESLs
* store: parametro associado a loja
* Parametros conforme doc da API
* path: Informar o "diretório" na qual o arquivo de resposta (GetAllStatusESL.json) deverá ser gravado.

### GetFailed

`int GetFailed(path *char, store *char)`
* Get ESLs com falhas
* store: parametro associado a loja
* Parametros conforme doc da API
* path: Informar o "diretório" na qual o arquivo de resposta (GetFailedESL.json) deverá ser gravado.

### GetEslStatus

`int GetEslStatus(path *char, eslId * char)`
* Consultar as informações do status ESL específico (eslId)
* Parametros conforme doc da API
* path: Informar o "diretório" na qual o arquivo de resposta (GetStatusESL.json) deverá ser gravado.

### BindingRelationshipESL

`int BindingRelationshipESL(path *char, eslId *char, goodsId *char)`
* Consultar as informações do relacionamento de ligação ESL específico por eslId ou goodsId.
* Parametros conforme doc da API
* path: Informar o "diretório" na qual o arquivo de resposta (BindingRelationshipESL.json) deverá ser gravado.

### ProductQuery

`int ProductQuery(path *char, codigo *char)`
* Consultar as informações do produto específico por ean ou sku (codigo).
* Parametros conforme doc da API
* path: Informar o "diretório" na qual o arquivo de resposta (ProductQuery.json) deverá ser gravado.

### UpdateStatusQueryBatch

`*char UpdateStatusQueryBatch(customerStoreCode *char, storeCode *char, batch *char)`
* Consultar o status do ESL por número do lote.
* Parametros conforme doc da API

### Habilitar Log da Biblioteca

Para habilitar o Log da biblioteca, seguir os passos abaixo:

No arquivo configParametros.json:

1. Setar a variável -> `"debugLog"`: `true`
2. Criar uma variável de ambiente (varAmbiente) e apontar a mesma para um arquivo txt.
    * Ex: `"ESL_LOG"`
    * valor: `C:\TESTE\log_esl.txt`
3. Os dados de Log serão inseridos no arquivo informado no passo anterior.
