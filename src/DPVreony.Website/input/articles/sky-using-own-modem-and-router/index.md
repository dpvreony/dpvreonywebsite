# Using your own Modem and Router with a Sky internet connection

| | |
| - | - |
| Article Status | Released |
| Article Version | 1.0 |
| First Written | 2020-08-09 |
| Last Revision | 2021-02-28 |
| License | MIT |

You may find the equipment provided by Sky for your internet connection is unreliable. This can be:

* Frequent Internet Connection drops.
* Wifi signal weakness with frequent drop outs.
* You experience internet\dns issues but appear to remain on a stable Wifi. When using a WiFi signal monitoring tool you notice that the Sky Q (or mini) boxes, or Signal Booster offer a stronger signal than the hub. What is happening in this scenario is you are connected on the mesh but the mesh device is losing connection to the hub.
* LAN ports won't route traffic over the internet port without a hard reset every few hours. Yet the wifi continues to have internet access.

Note: Sky have a paid offering of guaranteed signal strength. But read the small print and take with a pinch of salt. The hubs are cheap mass produced products and depending on the layout of your house (concrete walls etc.) you can only achieve so much with these services. If you're having issues with the mesh network you may want to consider connecting your SkyQ devices via network cables or over powerline adapters.

# Equipment you need

* A standalone modem and router than can support ?
* A combined modem \ router product that can support ?

# What is ?

? is an authentication mechanism that allows Internet Service Providers to authentication a connection via the phone line itself rather than a username and password (PPPoA \ PPPoE).

# Case Demonstration

In this demonstration I am going to detail how to configure using a standalone modem and a standalone router. The equipment I'm going to use is:

* DrayTek Vigor 130
* Netgear AC4000 Nighthawk X6S (R8000P)

DISCLAIMER: I have no vested interests in the organisations relating to these products. I also offer no gurantees or liabilities on these products.

WARNING: Before starting make sure your devices have up to date firmware. The stock netgear firmware as of 2020 doesn't show the necessary options in the management UI, but the latest firmware does.

# Setting up the DrayTek Vigor 130

INFO: Further details are available on the DrayTek Support Site.

## Setting up the Netgear AC4000 Nighthawk X6S (R8000P)

TODO

INFO: You may want to consider duplicating your Sky WiFi SSID and Password. Disable the WiFi first so not to cause any drop in service while setting up the replacement.

## Switching over

TODO
## Other options

### Age dependant netgear devices

I have successfully connected Sky internet connections using other Netgear devices. You should check if the model you're interested in has a firmware that supports ? or you could consider custom firmware but beware of the risks (such as bricking the device) and invalidating any warranty you may have.

Models (and firmware at the time) I've had success with:

* AC2600 Nighthawk using updated official netgear firmware v1.0.2.68
* N600 (WNDR3800) using OpenWRT firmware v19.07.03

## References

* (https://openwrt.org/toh/netgear/wndr3800)[OpenWRT Wiki: Netgear WNDR3800] Accessed 2020-08-11
