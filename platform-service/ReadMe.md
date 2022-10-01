App notes{}

A. PlatformService
1. Setup Data Model, Database MS-SQL
2. API Endpoint, CRUD
3. Send signal to CommandService (HttpClient)
4. Setup Dockerfile and run app behind docker

B. CommandService
1. Setup Data Model, Database In-Memory
2. Setup API endpoint CRUD
3. Setup Dockerfile and run app behind docker

C. Communicate between CommandService and PlatformService
1.1 via HttpClient (Http)
1.2 via gRPC 
1.3 via MessageBus (RabbitMQ)

D. Setup K8S 
1. Deployment
1.1 PlatformService-depl.yaml
1.2 CommandService-depl.yaml
2. Node Port
2.1 PlatformService-np.yaml
3. LoadBalancer
3.1 loadbalancer.yaml
4. SQL Server
4.1 mssql-depl.yaml
5. RabbitMQ
5.1 rabbitmq-depl.yaml

E. Setup RabbitMQ 




