# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
Codebase: Um único repositório versionado por aplicação, podendo ser implantado em múltiplos ambientes sem duplicar código.

Dependencies: Declarar e isolar explicitamente todas as dependências, nunca assumindo pacotes pré-instalados no sistema.

Config: Armazenar configurações em variáveis de ambiente, separando-as do código.

Backing Services: Tratar bancos de dados, filas, cache e SMTP como recursos acopláveis, acessíveis via URL/credenciais e substituíveis sem alterar código.

Build, Release, Run: Separar rigorosamente as etapas de build, release e run, garantindo releases imutáveis e rastreáveis.

Stateless Processes: Processos devem ser stateless e share-nothing, qualquer estado persistente vai para backing services.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
Apresentação (UI/View), Aplicação/Serviço, Domínio, Infraestrutura/Persistência, Cross-cutting

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
SOA é mais sobre reuso e integração corporativa, microserviços são sobre autonomia, escalabilidade e deploy independente por domínio de negócio.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
Centralizar a exposição, governança e segurança de APIs, oferecendo gateway, autenticação, rate limiting, versionamento, monitoramento, catálogo/portal de desenvolvedores e políticas de transformação.

Vantagens:
Segurança centralizada.
Rate limiting, quotas e throttling.
Observabilidade.
Versionamento e documentação (OpenAPI/Swagger).
Desacoplamento entre consumidores e backends.
Monetização e portal do desenvolvedor.
Desvantagens:
Ponto único de falha.
Latência adicional.
Custo de licenciamento/infraestrutura.
Complexidade operacional e curva de aprendizado.
Risco de gargalo e vendor lock-in.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Struct = valor, class = referência.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
A grande diferença é multiplataforma + open source + modularidade/performance.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
Protocolo	HTTP/1.1 HTTP/2
Formato	JSON
Contrato	OpenAPI/Swagger
Performance	Boa, mas payload maior	Alta, payload compacto, streaming nativo
Streaming	Limitado
Ferramentas	Amplo suporte, fácil debug
Uso típico	APIs públicas

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Em uma SPA, o client-side router intercepta mudanças de URL sem recarregar a página. Ele mapeia a URL para um componente/view e renderiza apenas a parte necessária

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
Cultura de colaboração e responsabilidade compartilhada, automação de build, testes, deploy e infraestrutura, CI/CD para feedback rápido e releases frequentes, observabilidade (métricas, logs, tracing) e monitoramento.

10. Explique sobre um método agile.

**Resposta:**
Scrum, framework ágil com papéis, artefatos e eventos. Trabalha em sprints curtas, entregando incrementos potencialmente utilizáveis, com inspeção e adaptação contínuas.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI: integrar código frequentemente ao tronco, com build e testes automatizados a cada commit, detectando falhas cedo.
CD: automatizar a entrega até um ambiente pronto para produção.
Ferramentas: GitHub Actions, GitLab CI, Jenkins, Azure DevOps, Docker/Kubernetes.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Containers:uma instância isolada de processos compartilhando o kernel.

Docker: uma implementação/ecossistema que usa containers, containers existem independentemente do Docker.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
OpenShift = Kubernetes empacotado e estendido com recursos enterprise e suporte.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
Vantagens: desacoplamento, reuso, contrato explícito, escalabilidade independente, integração com múltiplos canais.

Desvantagens: latência de rede, complexidade de governança/versionamento, múltiplos pontos de falha, overhead de segurança, custo operacional, risco de explosão de endpoints.

Preocupações: design do contrato, segurança, observabilidade, SLA, backward compatibility, documentação, deprecação, e definição de domínio (evitar APIs genéricas demais ou granulares demais).

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Autenticação forte, autorização, HTTPS/TLS obrigatório, gestão de segredos, logging, auditoria e monitoramento de anomalias.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Para desacoplar produtores e consumidores de forma assíncrona

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
SAGA gerencia transações distribuídas sem 2PC, quebrando uma transação de negócio em transações locais por serviço, com compensações em caso de falha.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps é uma abordagem em que o Git é a fonte única de verdade do estado desejado da infraestrutura e aplicações

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.
Contexto:
Atuei diretamente no projeto de migração do ERP Oracle E-Business Suite (EBS) para o Oracle Fusion Cloud ERP em uma empresa cujo CRM possui mais de 50 mil clientes ativos. O objetivo era modernizar a gestão corporativa, unificar processos e substituir integrações legadas por uma arquitetura mais robusta e baseada em APIs.
Problema/Necessidade:
O ambiente legado (EBS) tinha integrações ponto a ponto, muitas delas via banco de dados e arquivos, com baixa rastreabilidade, alto acoplamento e dificuldade de manutenção. A migração precisava ocorrer com mínimo de indisponibilidade, preservação da integridade dos dados de mais de 50 mil clientes e sem impactar a operação comercial e o CRM.
Minha atuação (desenvolvimento):
Integrações EBS/Fusion: desenvolvi integrações entre os sistemas (e posteriormente entre Fusion e o CRM), consumindo e expondo serviços via REST/SOAP (Oracle Integration Cloud / APIs do Fusion), com tratamento de erros, retry.
Carga de dados (Data Migration): participei do mapeamento, extração, transformação e carga de dados mestres e transacionais (clientes, endereços, contatos, condições comerciais) para o Fusion, usando FBDI (File-Based Data Import) e HDL (HCM Data Loader) quando aplicável, com validações e reconciliação de volumes.
Integração com o CRM: desenvolvi/ajustei integrações para sincronizar os mais de 50 mil clientes entre o CRM e o Fusion, garantindo consistência cadastral, deduplicação e tratamento de divergências.
Tratamento de dados e qualidade: criei rotinas de validação, logs de carga, relatórios de reconciliação (origem x destino) e scripts de correção para registros rejeitados.
Automação e monitoramento: automatizei execuções de carga/integração e monitorei erros, com alertas e reprocessamento controlado.
Tecnologias utilizadas:
Oracle EBS, Oracle Fusion Cloud ERP, Oracle Integration Cloud (OIC), REST/SOAP, FBDI/HDL, SQL/PLSQL, Python (scripts de extração/transformação e reconciliação), Git, Jenkins/Azure DevOps (pipelines), além de ferramentas de monitoramento e logs.
Desafios enfrentados:
Volume e integridade dos dados: migrar mais de 50 mil clientes e dados relacionados sem perdas, com regras de deduplicação e reconciliação rígidas.
Diferenças de modelo de dados entre EBS e Fusion, exigiu mapeamento detalhado e transformações complexas.
Janelas de migração curtas e necessidade de convivência temporária entre os sistemas sem impacto à operação.
Integrações legadas acopladas, refatoração para APIs e desacoplamento progressivo.
Tratamento de rejeições e erros de carga, construção de rotinas de reprocessamento e relatórios de reconciliação.
Alinhamento entre times (negócio, ERP, CRM, infra), comunicação constante e validações por fases (mock, testes integrados, UAT, go-live).

**Resposta:**
