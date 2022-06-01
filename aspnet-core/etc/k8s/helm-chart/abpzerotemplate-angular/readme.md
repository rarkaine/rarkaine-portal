Install using;

```bash
helm upgrade --install anz portal-angular
```

Uninstall all charts

```bash
helm uninstall anz
```

## Create Images

### run in the aspnet-core folder
```bash
docker build -t portal-host -f src\Rarkaine.Portal.Web.Host\Dockerfile .
docker build -t portal-migrator -f src\Rarkaine.Portal.Migrator\Dockerfile .
```

### run in the angular folder
```bash
docker build -t portal-angular -f Dockerfile . 
```
