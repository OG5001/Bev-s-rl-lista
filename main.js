async function init() {
    const response = await (fetch("/products.json"));
    const adatok = await response.json();

    const popup = document.getElementById('asd')
    const cimsorm = document.getElementById('cimsor')
    cimsorm.textContent = adatok.shopName;
    const Main = document.getElementById('ma')
    const d = document.getElementById('elso')



    for(const cards of adatok.products)
    {
        const div1 = document.createElement('div')
        const divbody = document.createElement('div')
        const Img = document.createElement('img')
        const Name = document.createElement('h5')
        const Price = document.createElement('p')
        const gomb = document.createElement('a')

        div1.classList.add("card")
        divbody.classList.add("card-body")
        Name.classList.add("card-title")
        Img.classList.add("card-img-top")
        Price.classList.add("card-text")
        gomb.classList.add("btn", "btn-success")

        gomb.textContent = "Reservation";
        Img.src = cards.img;
        Name.textContent = cards.name;
        Price.textContent = cards.price;

        Main.appendChild(d)
        d.appendChild(div1)
        div1.appendChild(Img)
        div1.appendChild(divbody)
        divbody.appendChild(Name)
        divbody.appendChild(Price)
        divbody.appendChild(gomb)

        gomb.addEventListener('click', function() {
            const dv = document.createElement('div')
            dv.classList.add("alert", "alert-success")
            dv.textContent = "Successful reservation"

            popup.appendChild(dv)
        });
    }
};
init();