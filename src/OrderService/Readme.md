# Order Service

**Objective**
<p>This will have the details about Order Service which we will be developing as part of Microservices L-200 session to our 'Amchi Dukan' application</p>

**Description**
<p>
This service is responsible for Order placing. It can have several sub-functionalities. This service will manage the entire process of order placing. Starts from searching item from inventory till the final order placement
</p>

**Expectations**
```
•	Add items to cart – User should be able to add searched items to the cart. Multiple items can be added at once.

•	Remove items from cart – User should be able to remove items from the cart.

•	Place order – User should be able to buy items from the cart. 

    -	Should be able to choose existing addresses or provide new address
    -	Should be able to choose existing card or add new card [Only one payment method for now]
    -	After successful payment –
        o	Order place should be successful.
        o	Reduce the inventory count.

```