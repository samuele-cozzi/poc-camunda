

helm install camunda-platform camunda/camunda-platform -n camunda -f camunda-platform-core-microk8s-values.yaml


microk8s kubectl config set-context --current --namespace=default
microk8s kubectl delete namespace camunda

microk8s kubectl create namespace camunda
microk8s kubectl config set-context --current --namespace=camunda

microk8s kubectl get pods
microk8s kubectl describe pods elasticsearch-master-0


microk8s kubectl port-forward svc/camunda-platform-zeebe-gateway 26500:26500 -n camunda
microk8s kubectl port-forward svc/camunda-platform-operate  8081:80
microk8s kubectl port-forward svc/camunda-platform-tasklist 8082:80
microk8s kubectl port-forward svc/camunda-platform-connectors 8088:8080



## Attenzione

cambaito la proprietà:

    storageClassName: "microk8s-hostpath"


kubectl delete pod camunda-platform-tasklist-7d54b5cbf9-lkpgx  --force --grace-period=0
kubectl delete pod elasticsearch-master-0 --force --grace-period=0
kubectl delete pod camunda-platform-zeebe-0 --force --grace-period=0