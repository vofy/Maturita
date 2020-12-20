# Bezdrátové sítě 

## bezdrátové sítě 
* DVBT2 (Televizní síť) 
* Rádiová síť 
* Bluetooth 
* Mobilní síť 
* Infraport 

## WiFi 
* Přenos dat bezdrátově 
* Pomalejší rychlost než kabelem 
* Nosič je elektromagnetická vlna 
* Médium je prostředí 
* SSID – název bezdrátové sítě 

#### Hardware
* AP, WIFI router, bezdrátová síťová karta

### Normy 
* 802.11a/b/g/n/ac/ax
![Normy](images/802.11.png)
* Každá má svojí pracovní frekvenci a rychlost  
* Využívá dva nelicencované kmitočty 2.4GHZ a 5GHz 

### Zabezpečení  
* WEP
* WPA
	* 64-bit nebo 128-bit šifrování
	* WPA-PSK (pre-shared-key)
	* WPA-EAP (využití s RADIUS serverem)
* WPA2
	* WPA2-PSK (pre-shared-key)
	* WPA2-EAP (využití s RADIUS serverem)
* Filtrování MAC

### Antény 
* Všesměrová (posílá signál všemi směry) 
* Směrová (posílá paprsek jedním směrem) 
* Sektorová (pokrývají určitý sektor) 
* Parabola
* Satelitní paraboly 

### Média 
* Koaxiální kabel
	* Tenký Ethernet
		* 10Base2 (10Mb/s, základní pásmo, délka max 200m)
		* Na jednom segmentu může být maximálně 30 stanic
		* Vzdálenost **mezi odbočkami** je **minimálně 50cm**, délka kabelu **od odbočky k síťové kartě** je **maximálně 30cm**
	* Tlustý Ethernet ("Žlutý kabel")
		* 10Base5 (10Mb/s, základní pásmo, délka max 500m)
		* Na jednom segmentu může být maximálně 100 stanic
	* Konektory – RSMA, SMA (např. pro připojení externí antény), U.FL (např. bezdrátové síťově karty)
	* **Téčko** - připojení zařízení v topologi BUS, **terminátor** - připojuje se na konec kabelu v BUS topologi a má odpor 50ohmů
* Prostředí (WiFi)
	* **2.4GHz** - relativně dobrá prostupnost prostředím, pomalejší
	* **5GHz** - špatná prostupnost prostředím, rychlejší
	* (60GHz - vysokorychlostní spoje, nízký atmosferický útlum)
