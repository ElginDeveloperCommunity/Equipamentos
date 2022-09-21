# Etiquetas Eletrônicas

### Descrição dos Abreviações
| Abreviação | Nome | Descrição | 
| :--- | :--- | :--- |
| AP | Wireless Access Point | Antena / Roteador que controla as etiquetas eletrônicas | 
| API | Application Programming Interface | Um conjunto de funções predefinidas para aplicações e desenvolvedores acessarem uma rotina baseada em um software, sem ter acesso ao código fonte ou necessário entendimento do processo |
| ESL | Eletronic Shelf Label | Etiqueta Eletrônica |
| PriSmart | PriSmart Smart Retail System | Plataforma que gerencia etiquetas e produtos das lojas |

# API

## 2.1 Interface de Integração

### 2.1.1 Informações da Request

**URL**: https://saas-poc-usa.hanshowcloud.net/integration/elgin/<`nome da loja`>
**Request Method**: POST

### 2.1.3 Headers
| Chave | Valor | Obrigatório | Descrição |
| :--- | :--- | :--- | :--- |
|Content-type | application/json;charset=utf-8 | Sim | |
| client-id | 1eb7b0e1a14736ef2c3cff1f187e7d7d | Sim | Fornecido pela Elgin |
| client-secret | c19a6b41c323a90a8551284457f9e197 | Sim | Fornecido pela Elgin |	

### 2.1.4 Exemplo de Request

#### 2.1.4.1 Exemplo para adicionar / atualizar produto
URL: https://saas-poc-usa.hanshowcloud.net /integration/elgin/<`nome da loja`>

```json
{
    "storeCode": "store", 
    "customerStoreCode": "elgin",
    "batchNo": "202004091103",
    "items":[
        {
            "sku": "103459",
            "ean" : "978020137962",
            "itemName": "Coca Cola",
            "price1": "1.34"
        }, {
            "sku": "103644",
            "ean" : "978020137962,379629780201,013799780262",
            "itemName": "Fanta",
            "price1": "1.30"
        }
    ]
}
```

#### 2.1.4.2 Possíveis respostas

<table>
    <thead>
        <tr>
            <th>No.</th>
            <th>HTTP Response Code</th>
            <th>Internal Response Code</th>
            <th>Mensagem</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>1</td>
            <td>200</td>
            <td>1001</td>
            <td>succeed</td>
        </tr>
        <tr>
            <td>2</td>
            <td rowspan=3>400</td>
            <td>1002</td>
            <td>Illegal integration data</td>
        </tr>
        <tr>
            <td>3</td>
            <td>1003</td>
            <td>Illegal field value format</td>
        </tr>
        <tr>
            <td>4</td>
            <td>1004</td>
            <td>Json data parse error</td>
        </tr>
        <tr>
            <td>5</td>
            <td>401</td>
            <td>1005</td>
            <td>Unauthorized</td>
        </tr>
        <tr>
            <td>6</td>
            <td rowspan=3>404</td>
            <td>1006</td>
            <td>API does not exist</td>
        </tr>
        <tr>
            <td>7</td>
            <td>1007</td>
            <td>Nonexisten store</td>
        </tr>
        <tr>
            <td>8</td>
            <td>1008</td>
            <td>Specified store is disabled</td>
        </tr>
        <tr>
            <td>9</td>
            <td>405</td>
            <td>1009</td>
            <td>Method Not Allowed</td>
        </tr>
        <tr>
            <td>10</td>
            <td>500</td>
            <td>1010</td>
            <td>Internal Error</td>
        </tr>
        <tr>
            <td>11</td>
            <td>503</td>
            <td>1011</td>
            <td>Service Unavailable</td>
        </tr>
    </tbody>
</table>

<br>

**Situação de Sucesso**
```json
{
    "storeCode": "store",
    "itemCount": 2000
}

```

**Situação de Erro**
```json
{
    "errorCode": 1002,
    "message" :  "Illegal integration data"
}

```
```json
{
    "errorCode": 1003,
    "message":  "Specified store is disabled"
}

```

<br>

### Descrição dos Campos para Produtos
| Name | Type | Length | Decimal | Required | Sample Value | Description |
| :--- | :--- | :---: | :---: | :--- | :--- | :--- |
| sku | varchar | 128 | 0 | YES | 1 | SKU |
| itemName | varchar | 256 | 0 | YES | Apple | Product name |
| price1 | decimal | 11 | 4 | YES | 12.9 | Retail price |
| itemShortName | varchar | 128 | 0 | NO	| | Product short name |
| freshItemCode | varchar | 128 | 0 | NO	| | Fresh food ID |
| ean | varchar | 2048 | 0 | YES | 6901028071468 | Product barcode |
| itemStatus | varchar | 128 | 0 | NO	| | Product status |
| brand | varchar | 128 | 0 | NO | head-shoulders | Brand |
| unit | varchar | 128 | 0 | NO	| | Unit |
| saleMode | varchar | 128 | 0 | NO| | Sale mode |
| placeOfOrigin | varchar | 128 | 0 | NO | USA | Place |
| specification	| varchar | 128 | 0 | NO | 125g x 5 | Specification |
| qrCode | varchar | 256 | 0 | NO | www.hanshows.com/id= | QR code |
| packSize | int | 11 | 0 | NO | 24 | Pack size |
| grade | varchar | 128 | 0 | NO | Qualified | Grade |
| description | text | 0 | 0 | NO	| | Product description/notes |
| level1CategoryCode | int | 11 | 0 | NO | 2 | Level1 category code |
| level1CategoryName | varchar | 128 | 0 | NO | Food | Level1 category name |
| level2CategoryCode | int | 11 | 0 | NO | 201 | Level2 category code |
| level2CategoryName | varchar | 128 | 0 | NO | Snack food | Level2 category name |
| level3CategoryCode | int | 11 | 0 | NO | 20103 | Level3 category code |
| level3CategoryName | varchar | 128 | 0 | NO | Sweet | Level3 category name |
| level4CategoryCode | int | 11 | 0 | NO | 2010301 | Level4 category code |
| level4CategoryName | varchar | 128 | 0 | NO | Hard candy | Level4 category name |
| level5CategoryCode | int | 11 | 0 | NO | 201030102 | Level5 category code |
| level5CategoryName | varchar | 128 | 0 | NO | Fruit-flavored hard candy | Level5 category name
| supevisedBy | varchar | 128 | 0 | NO| | Supervised by |
| supervisionHotline | varchar | 128 | 0 | NO	| | Supervision hotline |
| pricingStaff | varchar | 128 | 0 | NO | Pricing staff 1 | Pricing staff |
| Price1Description | varchar | 128 | 0 | NO | Retail price | Retail price description |
| price2 | decimal | 11 | 4 | NO | 11.9 | Promotion price |
| price2Description	| varchar | 128 | 0	| NO | Promotion price | Promotion price description |
| price3 | decimal | 11 | 4 | NO | 10.9 | Member price |
| price3Description | varchar |128 | 0 | NO | member price | Member price description |
| price4 | decimal | 11 | 4 | NO | 9.9 | Other price |
| price4Description | varchar | 128 | 0 | NO | Price spike | Other price description |
| price5 | decimal | 11 | 4 | NO | 13.5 | Market retail price |
| price5Description | varchar | 128 | 0 | NO | Market price | Market retail price Description | 
| price6 | decimal | 11 | 4 | NO	| | Discount price |
| price6Description | varchar | 128 | 0 | NO	| | Discount price description |
| promoDateFrom | datetime | 3 | 0 | NO	| | Promotion date from |
| promoDateTo | datetime | 3 | 0 | NO	| | Promotion date to |
| promoTimeFrom | time | 0 | 0 | NO	| | Promotion time from |
| promoTimeTo | time | 0 | 0 | NO	| | Promotion time to |
| vipDateFrom | datetime | 3 | 0 | NO	| | VIP date from |
| vipDateTo | datetime | 3 | 0 | NO	| | VIP date to |
| vipTimeFrom | time | 0 | 0 | NO	| | VIP time from |
| vipTimeTo | time | 0 | 0 | NO	| | VIP time to |
| promoReason | text | 0 | 0 | NO	| | Promotion reason |
| promoFlag | int | 11 | 0 | NO	| | Promotion flag |
| inventory | decimal | 11 | 4 | NO | Inventory quantity | Inventory | 
| safetyStock | decimal | 11 | 4 | NO	| | Safety stock |
| dms | decimal | 11 | 4 | NO | 8.3 | Daily sales |
| todaySalesQty | decimal | 11 | 4 | NO | 2.1 | Today sales quantity |
| cumulatedSalesQty | decimal | 11 | 4 | NO | 502.5 | Cumulated sales quantity |
| shelfQty | decimal | 11 | 4 | NO | 25 | Shelf quantity |
| shelfCode | varchar | 128 | 0 | NO	| | Shelf number/ product location number |
| shelfTier | varchar | 128 | 0 | NO	| | Shelf layer |
| shelfColumn | varchar | 128 | 0 | NO	| | Shelf column |
| displayLocation | varchar | 128 | 0 | NO | HH-CC-LL | Display location |
| supplierCode | varchar | 128 | 0 | NO	| | Supplier code |
| supplierName | varchar | 128 | 0 | NO	| | Supplier name |
| onOrderQty | decimal | 11 | 4 | NO	| | On order quantity |
| expiryDate | date | 0 | 0 | NO | May 2, 2017 | Expiry date |
| storageLife | varchar | 128 | 0 | NO | 180 days 1 year  | Storage life | 
| shelfLife | int | 11 | 0 | NO	| | Shelf life |
| ingredientTable | text | 0 | 0 | NO	| | Ingredient table |
| manufacturer | varchar | 128 | 0 | NO	| | Manufacturer name |
| manufacturerAddress | varchar | 256 | 0 | NO	| | Manufacturer address |
| memberPoints | decimal | 11 | 4 | NO | 15 | Member points |
| rsrvTxt1 | varchar | 256 | 0 | NO	| | Reserved field 1_text |
| rsrvTxt2 | varchar | 256 | 0 | NO	| | Reserved field 2_text |
| rsrvTxt3 | varchar | 256 | 0 | NO	| | Reserved field 3_text |
| rsrvTxt4 | varchar | 256 | 0 | NO	| | Reserved field 4_text |
| rsrvTxt5 | varchar | 256 | 0 | NO	| | Reserved field 5_text |
| rsrvTxt6 | varchar | 256 | 0 | NO	| | Reserved field 6_text |
| rsrvTxt7 | varchar | 256 | 0 | NO	| | Reserved field 7_text |
| rsrvTxt8 | varchar | 256 | 0 | NO	| | Reserved field 8_text |
| rsrvTxt9 | varchar | 256 | 0 | NO	| | Reserved field 9_text |
| rsrvTxt10 | varchar | 256 | 0 | NO	| | Reserved field 10_text |
| rsrvDec1 | decimal | 11 | 4 | NO	| | Reserved field 1_decimal |
| rsrvDec2 | decimal | 11 | 4 | NO	| | Reserved field 2_decimal |
| rsrvDec3 | decimal | 11 | 4 | NO	| | Reserved field 3_decimal |
| rsrvDec4 | decimal | 11 | 4 | NO	| | Reserved field 4_decimal |
| rsrvDec5 | decimal | 11 | 4 | NO	| | Reserved field 5_decimal |
| RsrvInt1 | int | 11 | 0 | NO	| | Reserved field 1_integer |
| RsrvInt2 | int | 11 | 0 | NO	| | Reserved field 2_integer |
| RsrvInt3 | int | 11 | 0 | NO	| | Reserved field 3_integer |
| RsrvInt4 | int | 11 | 0 | NO	| | Reserved field 4_integer |
| RsrvInt5 | int | 11 | 0 | NO	| | Reserved field 5_integer |
