# Containerized ElasticSearch stack playground #
## DISCLAIMER ##
This environment is built to preview new features on ElasticSearch on your local Docker environment and learn ElasticSearch. No production use!

## Images and host names ##
- All images are made available through official Elastic and Microsoft repos.
- ```filebeat```, configured to monitor /tmp/mylog.log and forward to logstash
- ```logstash``` listening standard beats port 5044 and forwarding messages using plain text codec
- ElasticSearch cluster from 3 nodes: ```es01```, ```es02``` and ```es03```
- ```kibana```
- ``` apm ``` APM server listening for incoming metrics and traces from apm-demo app and forwarding to elastic
- ``` apmdemo ``` Demo app using Elastic APM libs (.NET core)

## Volumes ##
- Only ElasticSearch data volumes are persistent. All other containers are completely stateless. If you screw things up, just remove docker-elasticsearch volumes and let them get recreated.

## Setting up ##
1. Make sure your PC has at least 8 GB of available RAM
2. Docker for MacOS or Windows (WSL2 has issue with kernel parameter, use Hyper-V mode) and configure its engine to use at least 8 Gb of RAM.
3. Open terminal and cd to project
4. run ```docker-compose up```


## Accessing ##
- Kibana is available through http://localhost:5601 in your browser
- ElasticSearch API is available through http://localhost:9200
- APM Demo is available through http://localhost:5000/swagger
