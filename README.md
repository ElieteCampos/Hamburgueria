# 🍔 LanchesMac - ASP.NET Core MVC

Projeto de estudo desenvolvido em **ASP.NET Core MVC** simulando um sistema de gerenciamento de lanches, pedidos e relatórios.  
O foco é praticar **CRUD, autenticação/autorização, upload de imagens, relatórios com FastReport e paginação**.

---

## 🚀 Tecnologias
- ASP.NET Core MVC 8  
- C#  
- Entity Framework Core + SQL Server  
- FastReport (relatórios/PDF)  
- ReflectionIT.Mvc.Paging (paginação)  
- Bootstrap  

---

## ⚙️ Funcionalidades
- **Categorias**: CRUD completo  
- **Lanches**: CRUD, filtro e paginação  
- **Pedidos**: listagem, detalhes e CRUD  
- **Imagens**: upload, listagem e exclusão  
- **Relatórios**:  
  - Lanches por categoria (com exportação PDF)  
  - Vendas por período  
- **Serviços**: integração com FastReport (`RelatorioLanchesService` e `HelperFastReport`)  
- **Dashboard**: gráficos de vendas e pedidos  

---

## ▶️ Execução
1. Configure `appsettings.json` com sua connection string do SQL Server.  
2. Rode as migrations:  
   ```bash
   dotnet ef database update

