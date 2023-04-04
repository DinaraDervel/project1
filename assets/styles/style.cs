/*Main colors*/
/*Font families*/
/*Screen sizes*/
/*Mixins*/
/*Reset*/
p {
  margin: 0;
}

h1,
h2,
h3,
h4,
h5,
h6 {
  margin: 0;
}

ul,
ol {
  padding: 0;
  margin: 0;
  list-style-type: none;
}

/*Box-sizing*/
* {
  box-sizing: border-box;
}

/*Class for h1 and h2*/
.title {
  font-family: "Manrope", sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 3em;
  line-height: 1.5em;
  color: #000000;
}
.title_white {
  color: #ffffff;
}
.title_center {
  text-align: center;
}

/*Class for button*/
.btn {
  border: 2px solid #0a2640;
  border-radius: 56px;
  padding: 16px 56px;
  font-family: "Open Sans", sans-serif;
  font-style: normal;
  font-weight: 700;
  font-size: 20px;
  line-height: 28px;
  color: #0a2640;
}
.btn:hover {
  cursor: pointer;
}
.btn_small {
  padding: 8px 40px;
  font-size: 16px;
  line-height: 24px;
}
.btn_smallest {
  padding: 1px 14px;
  font-size: 13px;
  line-height: 28px;
}
.btn_blue {
  background: #0a2640;
  color: #ffffff;
}
.btn_green {
  background: #65e4a3;
  border-color: #69e6a6;
}
.btn_white-border {
  border-color: #ffffff;
}

/*Class for section1 (Lera)*/
.header {
  width: 100%;
  height: 798px;
  overflow: hidden;
  position: relative;
  z-index: 0;
  background-color: #0a2640;
  margin-bottom: 61px;
}

/*Ellipse*/
.header::before {
  content: "";
  position: absolute;
  left: 55.5%;
  top: -789px;
  height: 1293px;
  width: 92.36%;
  border-radius: 46.18%;
  background-color: #1c3d5b;
  z-index: -1;
}

.header-container {
  width: 85%;
  margin: 0 auto;
  display: flex;
  justify-content: space-between;
  margin-top: 33px;
  margin-bottom: 64px;
}
.header-container__card {
  display: flex;
}
.header-container__menu {
  display: flex;
  align-items: center;
}
.header-container__link {
  text-decoration: none;
  color: #ffffff;
  font-family: "Open Sans", sans-serif;
  font-weight: 600;
  font-size: 1em;
  line-height: 1.5em;
  margin-right: 2.86%;
}

.header-section {
  width: 85%;
  margin: 0 auto;
}
.header-section__wrapper {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
}
.header-section__sidebar {
  width: 49.3%;
  height: 310px;
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  align-self: center;
}
.header-section__text {
  font-family: "Open Sans", sans-serif;
  font-size: 1em;
  line-height: 1.75em;
  color: #ffffff;
  margin-bottom: 40px;
}

.button {
  display: flex;
  justify-content: space-around;
}

.header-section-img {
  width: 44%;
  height: 423px;
  display: grid;
  grid-template-columns: 1fr 1fr;
  grid-template-rows: 1fr 1fr;
  gap: 26px;
}
.header-section-img__img1 {
  grid-area: 1/1/2/3;
}
.header-section-img__img2 {
  grid-area: 2/1/2/3;
}
.header-section-img__img3 {
  grid-area: 2/2/3/3;
}

.header-section-logo {
  margin-top: 89px;
  display: flex;
  justify-content: space-evenly;
  margin-bottom: 87px;
}
.header-section-logo__pic:first-child, .header-section-logo__pic:last-child {
  opacity: 0.3;
}

/*Class for section2 (Anna)*/
/*Class for section2 (Anna)*/
/*Block2 Cards*/
.block2 {
  width: 85%;
  margin: 0 auto;
}
.block2__title1 {
  font-family: "Open Sans", sans-serif;
  font-weight: 400;
  font-size: 20px;
  line-height: 32px;
  color: rgb(119, 119, 119);
  text-align: center;
}

.block2-cards {
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  margin: 0 auto;
  justify-content: center;
  margin-top: 78px;
  gap: 100px;
}

.block2-card1 {
  display: flex;
  flex-direction: column;
  align-content: center;
}

.block2-card2 {
  display: flex;
  flex-direction: column;
}

.block2-card3 {
  display: flex;
  flex-direction: column;
}

/* Explore page */
.explorepage {
  display: flex;
  flex-direction: row;
}

.explorepage-link {
  margin-top: 28px;
  font-family: "Open Sans", sans-serif;
  font-weight: 700;
  font-size: 20px;
  line-height: 36px;
  color: rgb(10, 38, 64);
  text-decoration: none;
  border-bottom: solid, rgb(10, 38, 64);
}

.arrow-right-icon {
  width: 24px;
  height: 26px;
  top: 7px;
  left: 12px;
  margin-left: 17px;
  margin-top: 32px;
}

h3 {
  font-family: "Open Sans", sans-serif;
  font-weight: 400;
  font-size: 24px;
  line-height: 36px;
  color: rgb(0, 0, 0);
  margin-top: 24px;
}

.paragraph2 {
  margin-top: 12px;
  font-family: "Open Sans", sans-serif;
  font-weight: 400;
  font-size: 20px;
  line-height: 32px;
  color: rgb(119, 119, 119);
  text-align: left;
}

/*Class for section3 (Katya G.)*/
.customers {
  width: 85%;
  margin: 0 auto;
  background-color: #ffffff;
}
.customers .btn {
  box-sizing: border-box;
  -webkit-appearance: none;
  -moz-appearance: none;
  appearance: none;
  background-color: transparent;
  cursor: pointer;
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-align-self: center;
  -ms-flex-item-align: center;
  align-self: start;
  text-decoration: none;
  text-align: center;
  text-transform: uppercase;
}
.customers .btn .btn:hover,
.customers .btn .btn:focus {
  color: #ffffff;
  outline: 0;
}
.customers .btn_blue {
  border-color: #0a2640;
  color: #ffffff;
  box-shadow: 0 0 40px 40px #0a2640 inset, 0 0 0 0 #0a2640;
  -webkit-transition: all 150ms ease-in-out;
  transition: all 150ms ease-in-out;
  margin-top: 5%;
}
.customers .btn_blue:hover {
  box-shadow: 0 0 10px 0 #0a2640 inset, 0 0 10px 4px #0a2640;
  color: #0a2640;
}
.customers .wrapper-img {
  flex-basis: 45%;
  position: relative;
}
.customers .customers-sidebar {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: start;
  flex-basis: 45%;
  padding-top: 5%;
}
.customers .customers-section-1 {
  display: flex;
  flex-direction: row;
  flex-wrap: nowrap;
  justify-content: space-between;
  max-height: 610px;
  margin-top: 5%;
}
.customers .customers-section-1__img {
  max-width: 100%;
  max-height: 506px;
}
.customers .customers-section-1__img-diagram {
  max-width: 100%;
  max-height: 388px;
  position: absolute;
  left: 30%;
  top: 35%;
}
.customers .customers-section-1__items {
  padding-top: 10%;
}
.customers .customers-section-1__item {
  display: inline-flex;
  align-items: center;
  margin-bottom: 5%;
}
.customers .customers-section-1__icon {
  max-width: 100%;
  max-height: 100%;
}
.customers .customers-section-1__text {
  font-family: "Open Sans", sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 1.1em;
  line-height: 160%;
  padding-left: 2vw;
  color: #000000;
}
.customers .customers-section-1 .customers-section-title {
  font-family: "Manrope", sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 1.9em;
  line-height: 156%;
  color: #000000;
}
.customers .customers-section-2 {
  display: flex;
  flex-direction: row;
  flex-wrap: nowrap;
  justify-content: space-between;
  margin-top: 15%;
  margin-bottom: 25%;
  max-height: 692px;
}
.customers .customers-section-2 .customers-section-title {
  margin-top: 10%;
}
.customers .customers-section-2__items {
  padding-top: 10%;
}
.customers .customers-section-2__item {
  display: inline-flex;
  align-items: center;
  width: 100%;
  height: 68px;
  box-shadow: 0px 4px 32px rgba(0, 0, 0, 0.08);
  border-radius: 4px;
  margin-bottom: 5%;
}
.customers .customers-section-2__item_blue {
  background: #0a2640;
}
.customers .customers-section-2__icon {
  max-width: 100%;
  margin: 5% 3% 5% 5%;
}
.customers .customers-section-2__text {
  font-family: "Open Sans", sans-serif;
  font-style: normal;
  font-weight: 600;
  font-size: 1em;
  line-height: 175%;
  color: #000000;
}
.customers .customers-section-2__text_white {
  color: #ffffff;
}
.customers .customers-section-2__img {
  max-width: 100%;
  max-height: 523px;
}
.customers .customers-section-2__img-diagram {
  max-width: 100%;
  max-height: 388px;
  position: absolute;
  left: 4%;
  top: 50%;
}

/*Class for section4 (Katya P.)*/
.block4 {
  max-width: 100%;
}
.block4__blue {
  background-color: #0a2640;
  padding-bottom: 10vh;
}
.block4__titled {
  width: 85%;
  margin: 0 auto;
  display: flex;
  justify-content: space-between;
  padding-top: 10vh;
}
.block4__title {
  flex-basis: 60%;
}
.block4__button-container {
  display: flex;
  padding-top: 10vh;
}
.block4__button-left, .block4__button-right {
  border-radius: 50%;
  border: none;
  background-color: transparent;
}
.block4__cards {
  display: flex;
  flex-wrap: wrap;
  width: 85%;
  margin: 0 auto;
  margin-top: 4vw;
  justify-content: flex-start;
  align-items: flex-start;
  overflow: hidden;
  position: relative;
}
.block4__card {
  flex-basis: 30%;
  display: flex;
  flex-direction: column;
  background-color: #ffffff;
  border-radius: 10px;
  align-items: center;
  padding-top: 1em;
  float: left;
  position: relative;
  margin-right: 2em;
}
.block4__text {
  width: 75%;
  font-family: "Open Sans", sans-serif;
  font-weight: 400;
  font-size: 3em;
  line-height: 4vw;
}
.block4__name {
  display: flex;
  width: 100%;
  margin: 2em;
  padding: 2em;
  gap: 1em;
}
.block4__names {
  font-family: "Open Sans", sans-serif;
  font-weight: 700;
  font-size: 16px;
  line-height: 32px;
  color: #0a2640;
}
.block4__position {
  font-family: "Open Sans", sans-serif;
  font-weight: 400;
  font-size: 14px;
  line-height: 32px;
  color: #0a2640;
}
.block4__img {
  width: 58px;
  height: 58px;
}
.block4__about {
  width: 85%;
  margin: 0 auto;
}
.block4__photo {
  max-width: 100%;
  width: 100%;
  border-radius: 24px;
  margin-top: 15vh;
}
.block4__accordion {
  display: flex;
  justify-content: space-between;
  padding-top: 7vh;
  padding-bottom: 5vh;
}
.block4__paragraph {
  flex-basis: 40%;
  font-family: "Manrope", sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 36px;
  line-height: 56px;
}
.block4__faq-container {
  flex-basis: 45%;
  height: 160px;
}
.block4__faq-down {
  display: flex;
  justify-content: space-between;
  padding-top: 2vh;
  padding-bottom: 1vh;
}
.block4__faq {
  font-family: "Open Sans", sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 20px;
  line-height: 32px;
}
.block4__down {
  width: 1.5em;
  height: 1.5em;
  margin-top: 0.5em;
}

/*Class for section5 (Nataly)*/
/*Class for section6 (Dinara)*/
.footer {
  width: 85%;
  margin: 0 auto;
}
.footer__container {
  height: 391px;
}
.footer__container_blue {
  position: relative;
  z-index: 0;
  overflow: hidden;
  background-color: #0a2640;
  border-radius: 12px;
  margin-bottom: 184px;
}
.footer__container_blue::before {
  content: "";
  position: absolute;
  left: 38.83%;
  right: -46.58%;
  top: -269.57%;
  bottom: 38.87%;
  height: 1293px;
  width: 1293px;
  border-radius: 646.5px;
  background-color: #1c3d5b;
  z-index: -1;
}
.footer__container_flex {
  display: flex;
  flex-direction: row;
  justify-content: flex-start;
  gap: 7vw;
}
.footer__subscribe {
  width: 55%;
  height: 100%;
  margin: 0 auto;
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
}
.footer__form {
  width: 80%;
  margin: 0 auto;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-around;
  gap: 24px;
}
.footer__input {
  flex-grow: 1;
  background: #ffffff;
  border: 2px solid #ffffff;
  border-radius: 240px;
  padding-left: 32px;
  font-family: "Open Sans", sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 20px;
  line-height: 32px;
}
.footer__card {
  flex-basis: 25%;
  display: flex;
  flex-direction: column;
  gap: 2.5vw;
}
.footer__card:first-of-type {
  margin-right: 10.3vw;
  gap: 40px;
}
.footer_paragraph {
  width: 21.4vw;
  font-family: "Open Sans", sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 16px;
  line-height: 28px;
  color: #777777;
}
.footer_paragraph:first-of-type {
  margin-bottom: 24px;
}
.footer__title {
  font-family: "Open Sans", sans-serif;
  font-style: normal;
  font-weight: 700;
  font-size: 20px;
  line-height: 32px;
}
.footer__menu {
  display: flex;
  flex-direction: column;
  gap: 35px;
}
.footer__link {
  display: flex;
  gap: 10px;
  text-decoration: none;
  font-family: "Open Sans", sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 20px;
  line-height: 32px;
  color: #777777;
}
@media (max-width: 1060px) {
  .footer {
    width: 95%;
    margin: 0 auto;
  }
  .footer__subscribe {
    width: 100%;
  }
  .footer__card:first-of-type {
    margin-right: 2vw;
  }
}

/*# sourceMappingURL=style.cs.map */
