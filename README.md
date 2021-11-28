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
1. Make sure your PC has at least 8 GB of available RAM and a decent CPU.
2. Docker desktop installed and its engine to allowed to use at least 8 Gb of RAM. On Windows with WSL2, make sure to set your docker VM with ```sysctl -w vm.max_map_count=262144```, see https://github.com/docker/for-win/issues/5202.
3. Open terminal and cd to project
4. ```docker-compose up```. You can optionally run parts of the stack, for example ```docker-compose up es01 es02 es03 kibana apm apmdemo```

## Accessing ##
- Kibana is available through http://localhost:5601 in your browser
- ElasticSearch API is available through http://localhost:9200
- APM Demo is available through http://localhost:5000/swagger
