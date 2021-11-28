# Containerized ElasticSearch stack playground #
## DISCLAIMER ##
This environment is built to preview new features on ElasticSearch on your local Docker environment and learn ElasticSearch. It is meant to be screwed, crashed, painted in red, pissed on the top of it and burned afterwards, thus no production use.

## Images and host names ##
- All images are made available through Artifactory acting as a proxy to official ElasticSearch docker repos.
- ```filebeat```, configured to monitor /tmp/mylog.log and forward to logstash
- ```logstash``` listening standard beats port 5044 and forwarding messages using plain text codec
- ElasticSearch cluster from 3 nodes: ```es01```, ```es02``` and ```es03```
- ```kibana```
- ``` apm ``` APM server
- ``` apmdemo ``` Demo app using Elastic APM libs (.NET core)

## Volumes ##
- Only ElasticSearch data volumes are persistent. All other containers are completely stateless. If you screw things up, just remove docker-elasticsearch volumes and let them get recreated.

## Setting up ##
1. Make sure your PC has at least 8 GB of available RAM
2. Obtain docker for Windows from SolveIT and configure its engine to use 8 Gb of RAM.
3. Open Powershell terminal and cd to project cloned
4. run ```docker-compose up```

## Accessing ##
Kibana is available through http://localhost:5601 in your browser
ElasticSearch API is available through http://localhost:9200
APM Demo is available through http://localhost:5000/swagger
