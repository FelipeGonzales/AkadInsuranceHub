# 🏦 Akad Insurance Hub - Sistema de Gestão de Seguros  

🚀 **Akad Insurance Hub** é um sistema de gerenciamento de apólices de seguros baseado em **microserviços**, **arquitetura cloud-native** e **tecnologias open-source**. O objetivo é fornecer um ambiente escalável, seguro e eficiente para corretoras de seguros e clientes.

---

## 📌 Tecnologias Utilizadas  

### ✅ **Backend (Microservices com .NET)**
- [.NET 8 / .NET Core](https://dotnet.microsoft.com/) - Framework principal para APIs
- [ASP.NET Core Web API](https://learn.microsoft.com/en-us/aspnet/core/) - Construção de APIs RESTful
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) - ORM para manipulação de banco de dados
- [Dapper](https://github.com/DapperLib/Dapper) - ORM alternativo para queries de alta performance
- [PostgreSQL](https://www.postgresql.org/) - Banco de dados relacional
- [MongoDB (Community Edition)](https://www.mongodb.com/try/download/community) - Banco de dados NoSQL
- [Redis](https://redis.io/) - Cache distribuído
- [MediatR](https://github.com/jbogard/MediatR) - Implementação de CQRS
- [MassTransit](https://masstransit.io/) + [RabbitMQ](https://www.rabbitmq.com/) - Mensageria para comunicação entre microserviços
- [Serilog](https://serilog.net/) + [Seq](https://datalust.co/seq) - Logging centralizado
- [Swagger / OpenAPI](https://swagger.io/) - Documentação das APIs
- [IdentityServer4 (Open-Source)](https://github.com/IdentityServer/IdentityServer4) - Autenticação e OAuth2
- [Keycloak](https://www.keycloak.org/) - Alternativa para autenticação Single Sign-On (SSO)

---

### ✅ **Frontend (React.js)**
- [React.js](https://react.dev/) - Framework para interface de usuário
- [TypeScript](https://www.typescriptlang.org/) - Tipagem estática para maior segurança no código
- [Vite.js](https://vitejs.dev/) - Ferramenta de build rápida para React
- [Material UI (MUI)](https://mui.com/) - Biblioteca de componentes modernos
- [Tailwind CSS](https://tailwindcss.com/) - Framework para estilização eficiente
- [Axios](https://axios-http.com/) - Cliente HTTP para comunicação com APIs
- [React Query](https://tanstack.com/query/latest) - Gerenciamento de estado para chamadas assíncronas

---

### ✅ **Infraestrutura & Deploy**
- [Docker](https://www.docker.com/) + [Docker Compose](https://docs.docker.com/compose/) - Containerização dos serviços
- [K3s (Lightweight Kubernetes)](https://k3s.io/) - Orquestração de containers
- [GitHub Actions](https://github.com/features/actions) - CI/CD automatizado
- [Fly.io](https://fly.io/) - Deploy gratuito para backend
- [Netlify](https://www.netlify.com/) / [Vercel](https://vercel.com/) - Deploy gratuito para frontend
- [Prometheus](https://prometheus.io/) + [Grafana](https://grafana.com/) - Monitoramento e métricas

---

## 📌 Funcionalidades do Projeto
✔ **Cadastro e Gestão de Clientes**  
✔ **Criação, Atualização e Exclusão de Apólices de Seguros**  
✔ **Simulação de Seguro baseada no perfil do cliente**  
✔ **Geração e Assinatura Digital de Contratos**  
✔ **Consulta de Pagamentos e Sinistros**  
✔ **Sistema de Notificações por E-mail (MailKit - Open Source)**  
✔ **Dashboard com Métricas de Seguro (Grafana + Prometheus)**  

---

## 🔧 Como Rodar o Projeto Localmente  

### 1️⃣ **Clone o Repositório**
```sh
git clone https://github.com/seu-usuario/AkadInsuranceHub.git
cd AkadInsuranceHub
```

### 2️⃣ **Suba os containers com Docker**
```sh
docker-compose up -d
```

### 3️⃣ **Acesse os serviços**
- **Backend API:** `http://localhost:5000/swagger`
- **Frontend React:** `http://localhost:3000`
- **RabbitMQ Management:** `http://localhost:15672`
- **Grafana Dashboard:** `http://localhost:3001`

---

## 🎯 Roadmap do Projeto
🔹 **Fase 1 - Configuração da Estrutura**
  - [x] Criar Microserviços (Clientes, Apólices, Pagamentos)
  - [x] Configurar API Gateway
  - [x] Configurar Docker e Docker Compose  
 
🔹 **Fase 2 - Desenvolvimento do Backend**
  - [ ] Implementar IdentityServer4 para Autenticação
  - [ ] Criar Modelos de Domínio (DDD)
  - [ ] Implementar CQRS com MediatR
  - [ ] Adicionar Mensageria com RabbitMQ
  - [ ] Criar Testes Unitários e Integração  
 
🔹 **Fase 3 - Desenvolvimento do Frontend**
  - [ ] Criar UI com React + Material UI
  - [ ] Implementar Gerenciamento de Estado com React Query
  - [ ] Integrar com as APIs  

🔹 **Fase 4 - Deploy & Monitoramento**
  - [ ] Configurar CI/CD com GitHub Actions
  - [ ] Deploy no Fly.io (Backend) e Netlify/Vercel (Frontend)
  - [ ] Implementar Logs e Monitoramento com Grafana + Prometheus  

---

## 📜 Licença
Este projeto está licenciado sob a **MIT License** - sinta-se à vontade para usar e modificar!

---

## 📩 Contato
✉ **Felipe Gonzales Rocha**  
🔗 [LinkedIn](https://www.linkedin.com/in/felipe-gonzales1)  
🔗 [GitHub](https://github.com/FelipeGonzales)  

🚀 _Bora codar!_  
