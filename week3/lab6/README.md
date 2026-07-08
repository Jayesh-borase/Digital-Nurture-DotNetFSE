<img width="1918" height="1028" alt="post_req_swagger" src="https://github.com/user-attachments/assets/39fc0a2f-d0ee-4875-b70e-ed161ecbe769" /><img width="1918" height="1028" alt="post_req_swagger" src="https://github.com/user-attachments/assets/5dd4c4ea-f3ec-4edf-9b45-cab6f174923d" /><img width="1918" height="1028" alt="post_req_swagger" src="https://github.com/user-attachments/assets/74659ed1-1796-46c3-8387-ce893065732a" /><img width="1918" height="1028" alt="post_req_swagger" src="https://github.com/user-attachments/assets/592bf000-a49d-4b7a-95b2-899be8f6c799" /><img width="1918" height="1028" alt="post_req_swagger" src="https://github.com/user-attachments/assets/554f9d77-71dc-4272-a951-c0eb4af1df46" /># Web API Handson 6 – Apache Kafka Integration with ASP.NET Core Web API

## Objective

The objective of this handson is to demonstrate integration between an ASP.NET Core Web API application and Apache Kafka using the Confluent.Kafka library. The application publishes employee data as Kafka messages to a Kafka topic, while a Kafka consumer receives and displays the published messages.

## Project Structure

```text
6.WebApi_Handson
│
├── EmployeeKafkaApi
│   ├── Controllers
│   ├── Models
│   ├── Services
│   ├── Program.cs
│   └── EmployeeKafkaApi.csproj
│
├── Kafka
│
├── Screenshots
│
└── README.md
```

## Implementation Steps

### Step 1

Created an ASP.NET Core Web API project named **EmployeeKafkaApi**.

### Step 2

Installed the **Confluent.Kafka** NuGet package to enable communication with the Apache Kafka broker.

### Step 3

Created an **Employee** model to represent the employee data that will be published as Kafka messages.

### Step 4

Implemented the **IKafkaProducerService** interface and **KafkaProducerService** class to publish serialized employee objects to the Kafka topic named **employee-topic**.

### Step 5

Registered the Kafka producer service using Dependency Injection in **Program.cs**.

### Step 6

Implemented the **EmployeeController** with a **POST** endpoint that accepts employee details and publishes the message to Kafka.

### Step 7

Started the Kafka broker and created the topic **employee-topic**.

### Step 8

Executed the **POST** endpoint using Swagger and verified that the employee data was successfully published to Kafka.

### Step 9

Verified the published messages using the Kafka Console Consumer.

## Execution Results

The application successfully publishes employee information from the ASP.NET Core Web API to the Kafka broker.

The Kafka Consumer continuously listens to the **employee-topic** and displays every published employee message.

Multiple employee messages were tested successfully.

## Screenshots

### Swagger POST Employee Request

<img width="1918" height="1028" alt="post_req_swagger" src="https://github.com/user-attachments/assets/aa1e69ed-b580-45ae-9a02-24972f33c759" />


### Kafka Consumer Receiving Message

<img width="1479" height="761" alt="producer_console_output" src="https://github.com/user-attachments/assets/7b458dcb-f735-4af3-b39c-1c2b814ada8d" />



### Kafka Topic Created Successfully

<img width="1482" height="755" alt="kafka_topic_created" src="https://github.com/user-attachments/assets/41aa9c0c-7157-43ba-b759-b8d14baf61f5" />


### Kafka Server Running

<img width="1474" height="764" alt="kafka_server_running" src="https://github.com/user-attachments/assets/f9a12184-42ad-4338-a267-a491e32ffe04" />


## Result

Successfully developed an ASP.NET Core Web API application that integrates with Apache Kafka using the Confluent.Kafka library. Employee information entered through the Web API is serialized and published to the Kafka topic, and the Kafka consumer successfully receives and displays the messages, demonstrating end-to-end message publishing using Apache Kafka.
