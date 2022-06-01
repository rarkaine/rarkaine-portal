Install using;

```bash
helm upgrade --install anz portal-mvc
```

Uninstall all charts

```bash
helm uninstall anz
```

## Create Images

```bash
docker build -t portal-mvc -f src\Rarkaine.Portal.Web.Mvc\Dockerfile .
docker build -t portal-migrator -f src\Rarkaine.Portal.Migrator\Dockerfile .
```
