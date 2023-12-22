import { Badge, Button, Card, Group, Image, Text } from "@mantine/core";
import classes from "../css/CardProductItem.module.css";

const CartProductItem = () => {
  return (
    <div className={classes.card_container}>
      <Card withBorder radius="md" className={classes.card}>
        <Card.Section className={classes.imageSection}>
          <Image src="https://i.imgur.com/ZL52Q2D.png" alt="Tesla Model S" />
        </Card.Section>
        <Group justify="space-between" mt="md">
          <div>
            <Text fw={500}>Tesla Model S</Text>
            <Text fz="xs" c="dimmed">
              Free recharge at any station
            </Text>
          </div>
          <Badge variant="outline">25% off</Badge>
        </Group>
        <Card.Section className={classes.section} mt="md">
          <Text fz="sm" c="dimmed" className={classes.label}>
            Basic configuration
          </Text>
          <Group gap={8} mb={-8}>
            {/* {features} */}
          </Group>
        </Card.Section>
        <Card.Section className={classes.section}>
          <Group gap={30}>
            <div>
              <Text fz="xl" fw={700} style={{ lineHeight: 1 }}>
                $168.00
              </Text>
              <Text
                fz="sm"
                c="dimmed"
                fw={500}
                style={{ lineHeight: 1 }}
                mt={3}
              >
                per day
              </Text>
            </div>
            <Button radius="md" style={{ flex: 1 }}>
              Rent now
            </Button>
          </Group>
        </Card.Section>
      </Card>
    </div>
  );
};

export default CartProductItem;
